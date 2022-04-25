using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Strengthify;
using Strengthify.Models;

namespace StrengthifyNETAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramsController : ControllerBase
    {
        private readonly StrengthifyContext _context;

        public ProgramsController(StrengthifyContext context)
        {
            _context = context;
        }

        // GET: api/Programs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Program>>> GetPrograms()
        {
            return await _context.Programs.ToListAsync();
        }

        // GET: api/Programs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Program>> GetProgram(int id)
        {
            var program = await _context.Programs.FindAsync(id);

            if (program == null)
            {
                return NotFound();
            }

            return program;
        }

        // PUT: api/Programs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProgram(int id, Program program)
        {
            if (id != program.Id)
            {
                return BadRequest();
            }

            _context.Entry(program).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProgramExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Programs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Program>> PostProgram(Program program)
        {
            _context.Programs.Add(program);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProgram", new { id = program.Id }, program);
        }

        // DELETE: api/Programs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProgram(int id)
        {
            var program = await _context.Programs.FindAsync(id);
            if (program == null)
            {
                return NotFound();
            }

            _context.Programs.Remove(program);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProgramExists(int id)
        {
            return _context.Programs.Any(e => e.Id == id);
        }
    }
}
