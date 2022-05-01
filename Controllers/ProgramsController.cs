using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Strengthify.Models;
using StrengthifyNETAPI.Dto;
using StrengthifyNETAPI.Services;

namespace StrengthifyNETAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramsController : ControllerBase
    {
        private readonly ProgramsService _programService;
        private readonly UserService _userService;

        public ProgramsController(ProgramsService programService, UserService userService)
        {
            _programService = programService;
            _userService = userService;
        }

        // GET: api/Programs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Program>>> GetPrograms()
        {
            return Ok(await _programService.GetAllProgramsAsync());
        }

        // GET: api/Programs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Program>> GetProgram(int id)
        {
            Program program = await _programService.GetProgramByIdAsync(id);

            if (program == null)
            {
                return NotFound();
            }

            return program;

        }

        // POST: api/Programs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProgramWriteDto>> PostProgram(ProgramWriteDto newProgram)
        {

            // check if program already exists
            Program program = await _programService.GetProgramByNameAsync(newProgram.ProgramName);
            User user = await _userService.GetUserByUuidAsync(newProgram.UserUuid);

            if (program != null)
            {
                return BadRequest("Program already exists.");
            }

            if (user == null)
            {
                return Unauthorized("User not authorized.");
            }

            int ProgramId = await _programService.CreateProgramAsync(newProgram, user);

            return CreatedAtAction("GetProgram", new { id = ProgramId }, newProgram);
        }

    }
}
