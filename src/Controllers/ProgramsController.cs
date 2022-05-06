using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StrengthifyNETAPI.Models;
using StrengthifyNETAPI.Dto;
using StrengthifyNETAPI.Repositories;

namespace StrengthifyNETAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramsController : ControllerBase
    {
        private readonly IProgramsRepository _programsRepository;
        private readonly IUsersRepository _UsersRepository;

        public ProgramsController(IProgramsRepository programsRepository, IUsersRepository UsersRepository)
        {
            _programsRepository = programsRepository;
            _UsersRepository = UsersRepository;
        }

        // GET: api/Programs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProgramReadDto>>> GetPrograms()
        {
            return Ok(await _programsRepository.GetAllProgramsAsync());
        }

        // GET: api/Programs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Program>> GetProgram(int id)
        {
            Program program = await _programsRepository.GetProgramByIdAsync(id);

            if (program == null)
            {
                return NotFound();
            }

            return Ok(program);

        }

        // POST: api/Programs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProgramWriteDto>> PostProgram(ProgramWriteDto newProgram)
        {

            // check if program already exists
            Program program = await _programsRepository.GetProgramByNameAsync(newProgram.ProgramName);
            User user = await _UsersRepository.GetUserByUuidAsync(newProgram.UserUuid);

            if (program != null)
            {
                return BadRequest("Program already exists.");
            }

            if (user == null)
            {
                return Unauthorized("User not authorized.");
            }

            int ProgramId = await _programsRepository.CreateProgramAsync(newProgram, user);

            return CreatedAtAction("GetProgram", new { id = ProgramId }, newProgram);
        }

    }
}
