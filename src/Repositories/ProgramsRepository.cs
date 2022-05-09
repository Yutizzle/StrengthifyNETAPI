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

        public async Task<IEnumerable<ProgramReadDto>> GetAllProgramsAsync()
        {
            List<ProgramReadDto> result = await _context.Programs
                .Select(x => new ProgramReadDto
                {
                    ProgramId = x.ProgramId,
                    ProgramName = x.ProgramName,
                    TotalCycleDays = x.TotalCycleDays
                })
                .ToListAsync();

            return result.AsEnumerable();
        }

        public async Task<ProgramReadDto> GetProgramByIdAsync(int id)
        {
            Program result = await _context.Programs.FirstOrDefaultAsync(x => x.ProgramId == id);

            return new ProgramReadDto
            {
                ProgramId = result.ProgramId,
                ProgramName = result.ProgramName,
                TotalCycleDays = result.TotalCycleDays
            };
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
                int workoutIndex = newProgram.Workouts.ToList().FindIndex(x => x.WorkoutKey == exercise.WorkoutKey);
                var newWorkoutExercise = new WorkoutExercise
                {
                    Workout = workouts[workoutIndex],
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
                int exerciseIndex = newProgram.Exercises.ToList().FindIndex(x => x.ExerciseKey == set.ExerciseKey);
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
                    WorkoutExercise = workoutExercises[exerciseIndex]
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
