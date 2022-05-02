using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StrengthifyNETAPI.Models;
using StrengthifyNETAPI.Dto;

namespace StrengthifyNETAPI.Repositories
{
    public class ProgramsRepository : IProgramsRepository
    {
        private readonly StrengthifyContext _context;

        public ProgramsRepository(StrengthifyContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Program>> GetAllProgramsAsync()
        {
            return await _context.Programs.ToListAsync();
        }

        public async Task<Program> GetProgramByIdAsync(int id)
        {
            return await _context.Programs.FindAsync(id);
        }

        public async Task<Program> GetProgramByNameAsync(string programName)
        {
            return await _context.Programs.SingleOrDefaultAsync(x => x.ProgramName == programName);
        }

        public async Task<ActionResult<int>> PutProgramAsync(int id, Program program)
        {
            _context.Entry(program).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return program.ProgramId;
        }

        public async Task<int> CreateProgramAsync(ProgramWriteDto newProgram, User user)
        {

            // build Program model
            var programs = new Program
            {
                ProgramName = newProgram.ProgramName,
                TotalCycleDays = newProgram.Workouts.Length,
                CreatedBy = user,
                UpdatedBy = user
            };

            _context.Programs.Add(programs);

            // build Workout model
            List<Workout> workouts = new List<Workout>();
            foreach (var workout in newProgram.Workouts)
            {
                var newWorkout = new Workout
                {
                    WorkoutName = workout.WorkoutName,
                    CreatedBy = user,
                    UpdatedBy = user
                };
                var newProgramDetail = new ProgramDetail
                {
                    Program = programs,
                    SequenceNum = workout.SequenceNum,
                    CycleDayNum = workout.CycleDayNum,
                    Workout = newWorkout,
                    CreatedBy = user,
                    UpdatedBy = user
                };

                _context.ProgramDetails.Add(newProgramDetail);
                _context.Workouts.Add(newWorkout);
                workouts.Add(newWorkout);
            }

            // build WorkoutExercise model
            List<WorkoutExercise> workoutExercises = new List<WorkoutExercise>();
            foreach (var exercise in newProgram.Exercises)
            {
                var newWorkoutExercise = new WorkoutExercise
                {
                    Workout = workouts.Single(c => c.WorkoutName == exercise.WorkoutName),
                    SequenceNum = exercise.SequenceNum,
                    Exercise = exercise.Exercise
                };

                _context.WorkoutExercises.Add(newWorkoutExercise);
                workoutExercises.Add(newWorkoutExercise);
            }

            // build WorkoutExerciseDetail model
            List<WorkoutExerciseDetail> workoutExerciseDetails = new List<WorkoutExerciseDetail>();
            List<IncrementFrequency> incrementFrequencies = _context.IncrementFrequencies.ToList();
            foreach (var set in newProgram.Sets)
            {

                var newWorkoutExerciseDetail = new WorkoutExerciseDetail
                {
                    Set = set.Set,
                    Reps = set.Reps,
                    Weight = set.Weight,
                    SetDuration = set.SetDuration,
                    SetRestDuration = set.SetRestDuration,
                    MaxReps = set.MaxReps,
                    MaxWeight = set.MaxWeight,
                    MaxSetDuration = set.MaxSetDuration,
                    WeightIncrementFrequency = incrementFrequencies.FirstOrDefault(x => x.IncrementFrequencyId == set.WeightIncrementFrequencyId),
                    RepsIncrementFrequency = incrementFrequencies.FirstOrDefault(x => x.IncrementFrequencyId == set.RepsIncrementFrequencyId),
                    SetDurationIncrementFrequency = incrementFrequencies.FirstOrDefault(x => x.IncrementFrequencyId == set.SetDurationIncrementFrequencyId),
                    WorkoutExercise = workoutExercises.FirstOrDefault(x => x.Exercise == set.Exercise)
                };

                _context.WorkoutExerciseDetails.Add(newWorkoutExerciseDetail);
            }

            // insert into database
            await _context.SaveChangesAsync();

            return programs.ProgramId;
        }

        public async void DeleteProgramAsync(int id)
        {
            var program = await _context.Programs.FindAsync(id);
            if (program == null)
            {
                return;
            }
            _context.Programs.Remove(program);
            await _context.SaveChangesAsync();

        }

        public bool ProgramExists(int id)
        {
            return _context.Programs.Any(e => e.ProgramId == id);
        }
    }
}