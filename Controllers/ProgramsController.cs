using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Strengthify;
using Strengthify.Models;
using StrengthifyNETAPI.Dto;

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
            if (id != program.ProgramId)
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
        public async Task<ActionResult<ProgramWriteDto>> PostProgram(ProgramWriteDto newProgram)
        {
            // check if program already exists
            var program = await _context.Programs.FindAsync(newProgram.ProgramName);
            var user = await _context.Users.FindAsync(newProgram.UserId);

            if(program != null)
            {
                return BadRequest();
            }

            if(user == null)
            {
                return Unauthorized();
            }

            // build Program model
            var programModel = new Program {
                ProgramName = newProgram.ProgramName,
                TotalCycleDays = newProgram.Workouts.Length,
                CreatedBy = user,
                UpdatedBy = user
            };   

            // build Workout model
            List<Workout> workouts = new List<Workout>();
            foreach(var workout in newProgram.Workouts)
            {
                var newWorkout = new Workout{
                    WorkoutName = workout.WorkoutName,
                    CreatedBy = user,
                    UpdatedBy = user
                };
                var newProgramDetail = new ProgramDetail {
                    SequenceNum = workout.SequenceNum,
                    CycleDayNum = workout.CycleDayNum,
                    Workout = newWorkout,
                    CreatedBy = user,
                    UpdatedBy = user
                };

                programModel.ProgramDetails.Add(newProgramDetail);
                workouts.Add(newWorkout);
            }  

            // build WorkoutExercise model
            List<WorkoutExercise> workoutExercises = new List<WorkoutExercise>();
            foreach(var exercise in newProgram.Exercises)
            {
                var newWorkoutExercise = new WorkoutExercise {
                    Workout = workouts.Single(c => c.WorkoutName == exercise.WorkoutName),
                    SequenceNum = exercise.SequenceNum,
                    Exercise = exercise.Exercise
                };
                
                workoutExercises.Add(newWorkoutExercise);
            }

            // build WorkoutExerciseDetail model
            List<WorkoutExerciseDetail> workoutExerciseDetails = new List<WorkoutExerciseDetail>();
            foreach(var set in newProgram.Sets)
            {
                var newWorkoutExerciseDetail = new WorkoutExerciseDetail {
                    Set = set.Set,
                    Reps = set.Reps,
                    Weight = set.Weight,
                    SetDuration = set.SetDuration,
                    SetRestDuration = set.SetRestDuration,
                    MaxReps = set.MaxReps,
                    MaxWeight = set.MaxWeight,
                    MaxSetDuration = set.MaxSetDuration,

                };
                
                workoutExerciseDetails.Add(newWorkoutExerciseDetail);
            }
            
            //_context.Programs.Add(program);

            try {
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateException) 
            {
                return Conflict();
            }

            return CreatedAtAction("GetProgram", new { id = program.ProgramId }, program);
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
            return _context.Programs.Any(e => e.ProgramId == id);
        }
    }
}
