using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public async Task<IEnumerable<ProgramReadLiteDto>> GetAllProgramsAsync()
        {
            List<ProgramReadLiteDto> result = await _context.Programs
                .Select(x => new ProgramReadLiteDto
                {
                    ProgramId = x.ProgramId,
                    ProgramName = x.ProgramName,
                    TotalCycleDays = x.TotalCycleDays
                })
                .ToListAsync();

            return result.AsEnumerable();
        }

        public async Task<ProgramReadLiteDto> GetProgramByIdAsync(int id)
        {
            Program result = await _context.Programs
                .FirstOrDefaultAsync(x => x.ProgramId == id);

            return new ProgramReadLiteDto
            {
                ProgramId = result.ProgramId,
                ProgramName = result.ProgramName,
                TotalCycleDays = result.TotalCycleDays
            };
        }

        public async Task<Program> GetProgramEntityByIdAsync(int id)
        {
            return await _context.Programs.FirstOrDefaultAsync(x => x.ProgramId == id);
        }

        public async Task<Program> GetProgramByNameAsync(string name)
        {
            return await _context.Programs.FirstOrDefaultAsync(x => x.ProgramName == name);

        }

        public async Task<ProgramReadFullDto> GetFullProgramByIdAsync(int id)
        {
            Program program = await _context.Programs.FirstOrDefaultAsync(x => x.ProgramId == id);

            List<Workout> workouts = await _context.ProgramDetails
                .Where(x => x.ProgramId == id)
                .OrderBy(x => x.SequenceNum)
                .Select(x => x.Workout)
                .ToListAsync();

            List<WorkoutExercise> exercises = await _context.WorkoutExercises
                .Where(x => workouts.Contains(x.Workout))
                .ToListAsync();

            List<WorkoutExerciseDetail> sets = await _context.WorkoutExerciseDetails
                .Where(x => exercises.Contains(x.WorkoutExercise))
                .ToListAsync();

            return new ProgramReadFullDto
            {
                ProgramId = program.ProgramId,
                ProgramName = program.ProgramName,
                TotalCycleDays = program.TotalCycleDays,
                Workouts = workouts.Select((x, i) => new WorkoutUpdateDto
                {
                    WorkoutId = x.WorkoutId,
                    WorkoutKey = x.WorkoutId.ToString(),
                    WorkoutName = x.WorkoutName,
                    SequenceNum = i,
                    CycleDayNum = i + 1
                }).ToArray(),
                Exercises = exercises.Select(x => new ExerciseUpdateDto
                {
                    WorkoutExerciseId = x.WorkoutExerciseId,
                    ExerciseKey = x.WorkoutExerciseId.ToString(),
                    Exercise = x.Exercise,
                    WorkoutKey = x.WorkoutId.ToString(),
                    SequenceNum = x.SequenceNum
                }).ToArray(),
                Sets = sets.Select(x => new SetUpdateDto
                {
                    WorkoutExerciseDetailId = x.WorkoutExerciseDetailId,
                    WorkoutKey = x.WorkoutExercise.WorkoutId.ToString(),
                    ExerciseKey = x.WorkoutExerciseId.ToString(),
                    Set = x.Set,
                    Reps = x.Reps,
                    Weight = x.Weight,
                    SetDuration = x.SetDuration,
                    SetRestDuration = x.SetRestDuration,
                    MaxReps = x.MaxReps,
                    MaxWeight = x.MaxWeight,
                    MaxSetDuration = x.MaxSetDuration,
                    RepsIncrementFrequencyId = x.RepsIncrementFrequencyId ?? 0,
                    WeightIncrementFrequencyId = x.WeightIncrementFrequencyId ?? 0,
                    SetDurationIncrementFrequencyId = x.SetDurationIncrementFrequencyId ?? 0,
                    RepsIncrementAmount = x.RepsIncrementAmount,
                    WeightIncrementAmount = x.WeightIncrementAmount,
                    SetDurationIncrementAmount = x.SetDurationIncrementAmount
                }).ToArray()
            };
        }

        public async Task<int> PutProgramAsync(ProgramUpdateDto newProgram, User user)
        {
            // get existing program
            Program program = await GetProgramEntityByIdAsync(newProgram.ProgramId);

            // update Program model
            program.ProgramId = program.ProgramId;
            program.ProgramName = newProgram.ProgramName;
            program.TotalCycleDays = newProgram.Workouts.Length;
            program.CreatedBy = program.CreatedBy;
            program.UpdatedBy = user;

            // extract new workouts
            List<WorkoutDto> newWorkouts = newProgram.Workouts
                .Where(x => x.WorkoutId == 0)
                .Select(x => new WorkoutDto
                {
                    WorkoutKey = x.WorkoutKey,
                    WorkoutName = x.WorkoutName,
                    SequenceNum = x.SequenceNum,
                    CycleDayNum = x.CycleDayNum
                })
                .ToList();

            newProgram.Workouts = newProgram.Workouts
                .Where(x => x.WorkoutId != 0)
                .Select(x => new WorkoutUpdateDto
                {
                    WorkoutId = x.WorkoutId,
                    WorkoutKey = x.WorkoutKey,
                    WorkoutName = x.WorkoutName,
                    SequenceNum = x.SequenceNum,
                    CycleDayNum = x.CycleDayNum
                })
                .ToArray();

            // extract new exercises related to new workouts
            List<ExerciseDto> newExercises = newProgram.Exercises
                .Where(x => x.WorkoutExerciseId == 0 && newWorkouts.FirstOrDefault(y => y.WorkoutKey == x.WorkoutKey) != null)
                .Select(x => new ExerciseDto
                {
                    ExerciseKey = x.ExerciseKey,
                    WorkoutKey = x.WorkoutKey,
                    Exercise = x.Exercise,
                    SequenceNum = x.SequenceNum
                })
                .ToList();

            newProgram.Exercises = newProgram.Exercises
                .Where(x => x.WorkoutExerciseId != 0)
                .Select(x => new ExerciseUpdateDto
                {
                    WorkoutExerciseId = x.WorkoutExerciseId,
                    ExerciseKey = x.ExerciseKey,
                    WorkoutKey = x.WorkoutKey,
                    Exercise = x.Exercise,
                    SequenceNum = x.SequenceNum
                })
                .ToArray();

            // extract new sets related to new workouts
            List<SetDto> newSets = newProgram.Sets
                .Where(x => x.WorkoutExerciseDetailId == 0 && newWorkouts.FirstOrDefault(y => y.WorkoutKey == x.WorkoutKey) != null)
                .Select(x => new SetDto
                {
                    WorkoutKey = x.WorkoutKey,
                    ExerciseKey = x.ExerciseKey,
                    Set = x.Set,
                    Reps = x.Reps,
                    Weight = x.Weight,
                    SetDuration = x.SetDuration,
                    MaxReps = x.MaxReps,
                    MaxWeight = x.MaxWeight,
                    MaxSetDuration = x.MaxSetDuration,
                    RepsIncrementFrequencyId = x.RepsIncrementFrequencyId,
                    WeightIncrementFrequencyId = x.WeightIncrementFrequencyId,
                    SetDurationIncrementFrequencyId = x.SetDurationIncrementFrequencyId,
                    RepsIncrementAmount = x.RepsIncrementAmount,
                    WeightIncrementAmount = x.WeightIncrementAmount,
                    SetDurationIncrementAmount = x.WeightIncrementAmount
                })
                .ToList();

            newProgram.Sets = newProgram.Sets
                .Where(x => x.WorkoutExerciseDetailId != 0)
                .Select(x => new SetUpdateDto
                {
                    WorkoutExerciseDetailId = x.WorkoutExerciseDetailId,
                    WorkoutKey = x.WorkoutKey,
                    ExerciseKey = x.ExerciseKey,
                    Set = x.Set,
                    Reps = x.Reps,
                    Weight = x.Weight,
                    SetDuration = x.SetDuration,
                    MaxReps = x.MaxReps,
                    MaxWeight = x.MaxWeight,
                    MaxSetDuration = x.MaxSetDuration,
                    RepsIncrementFrequencyId = x.RepsIncrementFrequencyId,
                    WeightIncrementFrequencyId = x.WeightIncrementFrequencyId,
                    SetDurationIncrementFrequencyId = x.SetDurationIncrementFrequencyId,
                    RepsIncrementAmount = x.RepsIncrementAmount,
                    WeightIncrementAmount = x.WeightIncrementAmount,
                    SetDurationIncrementAmount = x.WeightIncrementAmount
                })
                .ToArray();

            // add new workouts, exercise, and sets
            CascadeAddNewWorkouts(program.ProgramId, newWorkouts, newExercises, newSets, user);

            // get existing program details with programId
            List<ProgramDetail> programDetails = await _context.ProgramDetails
                .Include(x => x.Workout)
                .Where(x => x.ProgramId == program.ProgramId)
                .ToListAsync();

            // extract workouts from program details
            List<Workout> workouts = programDetails.Select(x => x.Workout).ToList();

            // get workouts to delete from program details
            List<Workout> workoutsDelete = workouts
                .Where(x => newProgram.Workouts.FirstOrDefault(y => y.WorkoutId == x.WorkoutId) == null)
                .ToList();

            // get workout exercises to delete
            List<WorkoutExercise> exercisesDelete = await _context.WorkoutExercises.ToListAsync();
            exercisesDelete = exercisesDelete
                .Where(x => workouts.FirstOrDefault(y => y.WorkoutId == x.WorkoutId) != null &&
                    newProgram.Exercises.FirstOrDefault(y => y.WorkoutExerciseId == x.WorkoutExerciseId) == null)
                .ToList();

            // get workout exercise details to delete
            List<WorkoutExerciseDetail> setsDelete = await _context.WorkoutExerciseDetails.ToListAsync();
            setsDelete = setsDelete
                .Where(x => workouts.FirstOrDefault(y => y.WorkoutId == x.WorkoutExercise.WorkoutId) != null &&
                    newProgram.Sets.FirstOrDefault(y => y.WorkoutExerciseDetailId == x.WorkoutExerciseDetailId) == null)
                .ToList();

            // delete 
            foreach (var set in setsDelete) { await DeleteWorkoutExerciseDetailAsync(set.WorkoutExerciseDetailId); };
            foreach (var exercise in exercisesDelete) { await CascadeDeleteWorkoutExerciseAsync(exercise.WorkoutExerciseId); };
            foreach (var workout in workoutsDelete) { await CascadeDeleteWorkoutAsync(workout.WorkoutId); };

            // update Workout model
            foreach (var updateWorkoutDto in newProgram.Workouts)
            {
                // check if exists
                ProgramDetail programDetail = programDetails.FirstOrDefault(x => x.WorkoutId == updateWorkoutDto.WorkoutId);
                Workout workout = workouts.FirstOrDefault(x => x.WorkoutId == updateWorkoutDto.WorkoutId);

                // update existing workouts
                workout.WorkoutName = updateWorkoutDto.WorkoutName;
                workout.UpdatedBy = user;

                // update existing program details
                programDetail.Workout = workout;
                programDetail.SequenceNum = updateWorkoutDto.SequenceNum;
                programDetail.CycleDayNum = updateWorkoutDto.CycleDayNum;

                _context.Workouts.Update(workout);
                _context.ProgramDetails.Update(programDetail);

            }

            // update or add workout exercise model
            List<WorkoutExercise> workoutExercises = new List<WorkoutExercise>();
            foreach (var exercise in newProgram.Exercises)
            {
                WorkoutExercise workoutExercise = await _context.WorkoutExercises
                    .FirstOrDefaultAsync(x => x.WorkoutExerciseId == exercise.WorkoutExerciseId);

                // create workout exercise if not exists
                if (workoutExercise == null)
                {
                    var newWorkoutExercise = new WorkoutExercise
                    {
                        WorkoutId = newProgram.Workouts.FirstOrDefault(x => x.WorkoutKey == exercise.WorkoutKey).WorkoutId,
                        SequenceNum = exercise.SequenceNum,
                        Exercise = exercise.Exercise,
                        CreatedBy = user,
                        UpdatedBy = user
                    };

                    _context.WorkoutExercises.Add(newWorkoutExercise);
                    workoutExercises.Add(newWorkoutExercise);
                    break;
                }

                workoutExercise.Exercise = exercise.Exercise;
                workoutExercise.SequenceNum = exercise.SequenceNum;
                workoutExercise.UpdatedBy = user;

                _context.WorkoutExercises.Update(workoutExercise);
                workoutExercises.Add(workoutExercise);
            }

            // update or add Workout Exercise Detail model
            List<WorkoutExerciseDetail> workoutExerciseDetails = new List<WorkoutExerciseDetail>();
            List<IncrementFrequency> incrementFrequencies = _context.IncrementFrequencies.ToList();
            foreach (var set in newProgram.Sets)
            {
                WorkoutExerciseDetail workoutExerciseDetail = _context.WorkoutExerciseDetails
                    .FirstOrDefault(x => x.WorkoutExerciseDetailId == set.WorkoutExerciseDetailId);

                int exerciseIndex = newProgram.Exercises.ToList().FindIndex(x => set.ExerciseKey == x.ExerciseKey);

                // create set if not exists
                if (workoutExerciseDetail == null)
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
                        WorkoutExercise = workoutExercises[exerciseIndex],
                        CreatedBy = user,
                        UpdatedBy = user
                    };

                    _context.WorkoutExerciseDetails.Add(newWorkoutExerciseDetail);
                    break;
                }

                // update set
                workoutExerciseDetail.Set = set.Set;
                workoutExerciseDetail.Reps = set.Reps;
                workoutExerciseDetail.Weight = set.Weight;
                workoutExerciseDetail.SetDuration = set.SetDuration;
                workoutExerciseDetail.SetRestDuration = set.SetRestDuration;
                workoutExerciseDetail.MaxReps = set.MaxReps;
                workoutExerciseDetail.MaxWeight = set.MaxWeight;
                workoutExerciseDetail.MaxSetDuration = set.MaxSetDuration;
                workoutExerciseDetail.WeightIncrementFrequency = incrementFrequencies.FirstOrDefault(x => x.IncrementFrequencyId == set.WeightIncrementFrequencyId);
                workoutExerciseDetail.RepsIncrementFrequency = incrementFrequencies.FirstOrDefault(x => x.IncrementFrequencyId == set.RepsIncrementFrequencyId);
                workoutExerciseDetail.SetDurationIncrementFrequency = incrementFrequencies.FirstOrDefault(x => x.IncrementFrequencyId == set.SetDurationIncrementFrequencyId);
                workoutExerciseDetail.UpdatedBy = user;

                _context.WorkoutExerciseDetails.Update(workoutExerciseDetail);
            }

            // insert into database
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

            CascadeAddNewWorkouts(programs.ProgramId, newProgram.Workouts.ToList(), newProgram.Exercises.ToList(), newProgram.Sets.ToList(), user);

            // insert into database
            await _context.SaveChangesAsync();

            return programs.ProgramId;
        }

        public Workout AddNewWorkout(Program program, WorkoutDto workout, User user)
        {
            var newWorkout = new Workout
            {
                WorkoutName = workout.WorkoutName,
                CreatedBy = user,
                UpdatedBy = user
            };
            _context.Workouts.Add(newWorkout);

            return newWorkout;
        }

        public List<Workout> CascadeAddNewWorkouts(int programId, List<WorkoutDto> workouts, List<ExerciseDto> exercises, List<SetDto> sets, User user)
        {
            // build Workout model
            List<Workout> addedWorkouts = new List<Workout>();
            foreach (var workout in workouts)
            {
                var newWorkout = new Workout
                {
                    WorkoutName = workout.WorkoutName,
                    CreatedBy = user,
                    UpdatedBy = user
                };
                var newProgramDetail = new ProgramDetail
                {
                    ProgramId = programId,
                    SequenceNum = workout.SequenceNum,
                    CycleDayNum = workout.CycleDayNum,
                    Workout = newWorkout,
                    CreatedBy = user,
                    UpdatedBy = user
                };

                _context.ProgramDetails.Add(newProgramDetail);
                _context.Workouts.Add(newWorkout);
                addedWorkouts.Add(newWorkout);
            }
            _context.Workouts.AddRange(addedWorkouts);

            // build WorkoutExercise model
            List<WorkoutExercise> workoutExercises = new List<WorkoutExercise>();
            foreach (var exercise in exercises)
            {
                int workoutIndex = workouts.FindIndex(x => x.WorkoutKey == exercise.WorkoutKey);
                var newWorkoutExercise = new WorkoutExercise
                {
                    Workout = addedWorkouts[workoutIndex],
                    SequenceNum = exercise.SequenceNum,
                    Exercise = exercise.Exercise,
                    CreatedBy = user,
                    UpdatedBy = user
                };

                _context.WorkoutExercises.Add(newWorkoutExercise);
                workoutExercises.Add(newWorkoutExercise);
            }

            // build WorkoutExerciseDetail model
            List<WorkoutExerciseDetail> workoutExerciseDetails = new List<WorkoutExerciseDetail>();
            List<IncrementFrequency> incrementFrequencies = _context.IncrementFrequencies.ToList();
            foreach (var set in sets)
            {
                int exerciseIndex = exercises.FindIndex(x => x.ExerciseKey == set.ExerciseKey);
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
                    WorkoutExercise = workoutExercises[exerciseIndex],
                    CreatedBy = user,
                    UpdatedBy = user
                };

                _context.WorkoutExerciseDetails.Add(newWorkoutExerciseDetail);
            }

            return addedWorkouts;
        }

        public ProgramDetail AddNewProgramDetail(Program program, WorkoutDto workoutDto, Workout workout, User user)
        {
            var newProgramDetail = new ProgramDetail
            {
                Program = program,
                SequenceNum = workoutDto.SequenceNum,
                CycleDayNum = workoutDto.CycleDayNum,
                Workout = workout,
                CreatedBy = user,
                UpdatedBy = user
            };

            _context.ProgramDetails.Add(newProgramDetail);

            return newProgramDetail;
        }

        public async Task<int> DeleteProgramAsync(int id)
        {
            Program program = await _context.Programs.FindAsync(id);
            if (program == null)
            {
                return 0;
            }
            _context.Programs.Remove(program);
            await _context.SaveChangesAsync();

            return id;
        }
        public async Task<int> DeleteWorkoutAsync(int id)
        {
            Workout workout = await _context.Workouts.FindAsync(id);
            if (workout == null)
            {
                return 0;
            }
            _context.Workouts.Remove(workout);
            await _context.SaveChangesAsync();

            return id;
        }

        public async Task<int> CascadeDeleteWorkoutAsync(int id)
        {
            // validate
            Workout workout = await _context.Workouts.FindAsync(id);

            if (workout == null)
            {
                return 0;
            }

            // get program detail with workouts that don't exist in newProgram workouts
            List<ProgramDetail> programDetailsDelete = _context.ProgramDetails
                .Where(x => x.WorkoutId == id)
                .ToList();

            // get workout exercises to delete
            List<WorkoutExercise> workoutExercisesDelete = _context.WorkoutExercises
                .Where(x => x.WorkoutId == id)
                .ToList();

            // get workout exercise details to delete
            List<WorkoutExerciseDetail> workoutExerciseDetailsDelete = _context.WorkoutExerciseDetails.ToList();
            workoutExerciseDetailsDelete = workoutExerciseDetailsDelete
                .Where(x => workoutExercisesDelete.FirstOrDefault(y => y.WorkoutExerciseId == x.WorkoutExerciseId) != null)
                .ToList();

            // delete
            workoutExerciseDetailsDelete.ForEach(async (x) => await DeleteWorkoutExerciseDetailAsync(x.WorkoutExerciseDetailId));
            workoutExercisesDelete.ForEach(async (x) => await DeleteWorkoutExerciseAsync(x.WorkoutExerciseId));
            programDetailsDelete.ForEach(async (x) => await DeleteProgramAsync(x.ProgramDetailId));
            await DeleteWorkoutAsync(id);

            return id;
        }

        public async Task<int> DeleteWorkoutExerciseAsync(int id)
        {
            // validate
            WorkoutExercise workoutExercise = await _context.WorkoutExercises.FindAsync(id);
            if (workoutExercise == null)
            {
                return 0;
            }

            // delete
            _context.WorkoutExercises.Remove(workoutExercise);
            await _context.SaveChangesAsync();

            return id;
        }

        public async Task<int> CascadeDeleteWorkoutExerciseAsync(int id)
        {
            // validate
            WorkoutExercise workoutExercise = await _context.WorkoutExercises.FindAsync(id);

            if (workoutExercise == null)
            {
                return 0;
            }

            // get workout exercise details to delete
            List<WorkoutExerciseDetail> workoutExerciseDetailsDelete = _context.WorkoutExerciseDetails
                .Where(x => x.WorkoutExerciseId == id)
                .ToList();

            // delete
            workoutExerciseDetailsDelete.ForEach(async (x) => await DeleteWorkoutExerciseDetailAsync(x.WorkoutExerciseDetailId));
            await DeleteWorkoutExerciseAsync(id);

            return id;
        }

        public async Task<int> DeleteWorkoutExerciseDetailAsync(int id)
        {
            // validate
            WorkoutExerciseDetail workoutExerciseDetail = await _context.WorkoutExerciseDetails.FindAsync(id);
            if (workoutExerciseDetail == null)
            {
                return 0;
            }

            // delete
            _context.WorkoutExerciseDetails.Remove(workoutExerciseDetail);
            await _context.SaveChangesAsync();

            return id;
        }

        public bool ProgramExists(int id)
        {
            return _context.Programs.Any(e => e.ProgramId == id);
        }
    }
}
