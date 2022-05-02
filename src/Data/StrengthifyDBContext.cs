using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using StrengthifyNETAPI.Models;

namespace StrengthifyNETAPI
{
    public class StrengthifyContext : DbContext
    {
        public StrengthifyContext(DbContextOptions<StrengthifyContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<IncrementFrequency> IncrementFrequencies { get; set; }
        public DbSet<Program> Programs { get; set; }
        public DbSet<ProgramDetail> ProgramDetails { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<WorkoutExercise> WorkoutExercises { get; set; }
        public DbSet<WorkoutExerciseDetail> WorkoutExerciseDetails { get; set; }

        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            AddTimestamps();
            return await base.SaveChangesAsync();
        }

        public void AddTimestamps()
        {
            // get all records which have been added or modified
            var entities = ChangeTracker.Entries().Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

            // update UpdatedAt, update CreatedAt only if it is a new record
            foreach (var entity in entities)
            {
                var now = DateTime.UtcNow;
                if (entity.State == EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).CreatedAt = now;
                }
                ((BaseEntity)entity.Entity).UpdatedAt = now;
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DateTime now = DateTime.UtcNow;
            int uniqueId = 1;

            // seed admin user
            User admin = new User
            {
                UserId = uniqueId++,
                Uuid = Guid.NewGuid(),
                FirstName = "Admin",
                LastName = "Admin",
                DateOfBirth = DateTime.SpecifyKind(DateTime.Parse("1994-02-03").Date, DateTimeKind.Utc),
                Email = "admin@admin.com",
                ProgramRun = 0,
                CreatedById = 1,
                CreatedAt = now,
                UpdatedById = 1,
                UpdatedAt = now
            };
            modelBuilder.Entity<User>().HasData(admin);

            // seed increment frequencies
            List<string> frequencies = new List<string> { "CYCLE_END", "MAX_REPS_REACHED", "MAX_WEIGHT_REACHED", "NEW_PR", "MAX_SET_DURATION_REACHED" };
            List<IncrementFrequency> frequencyEntities = new List<IncrementFrequency>();
            foreach (string frequency in frequencies)
            {
                frequencyEntities.Add(new IncrementFrequency
                {
                    IncrementFrequencyId = uniqueId++,
                    Frequency = frequency,
                    CreatedById = admin.UserId,
                    CreatedAt = now,
                    UpdatedById = admin.UserId,
                    UpdatedAt = now
                });
            }
            modelBuilder.Entity<IncrementFrequency>().HasData(frequencyEntities);

            // seed program
            Program programEntity = new Program
            {
                ProgramId = uniqueId++,
                ProgramName = "Simple 3x5",
                TotalCycleDays = 4,
                CreatedById = admin.UserId,
                CreatedAt = now,
                UpdatedById = admin.UserId,
                UpdatedAt = now,
            };
            modelBuilder.Entity<Program>().HasData(programEntity);

            // seed workouts and program details
            List<string> workouts = new List<string> { "Bench Day", "Squat Day", "Overhead Press Day", "Deadlift Day" };
            List<Workout> workoutEntities = new List<Workout>();
            List<ProgramDetail> programDetailEntities = new List<ProgramDetail>();
            foreach (var (workout, i) in workouts.Select((workout, i) => (workout, i)))
            {
                Workout newWorkout = new Workout
                {
                    WorkoutId = uniqueId++,
                    WorkoutName = workout,
                    CreatedById = admin.UserId,
                    CreatedAt = now,
                    UpdatedById = admin.UserId,
                    UpdatedAt = now,
                };
                workoutEntities.Add(newWorkout);

                programDetailEntities.Add(new ProgramDetail
                {
                    ProgramDetailId = uniqueId++,
                    ProgramId = programEntity.ProgramId,
                    WorkoutId = newWorkout.WorkoutId,
                    SequenceNum = i,
                    CycleDayNum = i + 1,
                    CreatedById = admin.UserId,
                    CreatedAt = now,
                    UpdatedById = admin.UserId,
                    UpdatedAt = now,
                });
            }
            modelBuilder.Entity<Workout>().HasData(workoutEntities);
            modelBuilder.Entity<ProgramDetail>().HasData(programDetailEntities);

            // seed workout exercises
            Dictionary<string, string[]> workoutExerciseMapping = new Dictionary<string, string[]>{
                {"Bench Day", new string[]{"Bench Press", "Overhead Press", "T-Bar Row", "Tricep Pushdown", "Dumbbell Bicep Curl"}},
                {"Squat Day", new string[]{"Squat", "Romanian Deadlift", "Lat Pull Down", "Bulgarian Split Squat", "Jump Rope"}},
                {"Overhead Press Day", new string[]{"Overhead Press", "Incline Bench Press", "Barbell Row", "Tricep Overhead Extension", "Dumbbell Lat Raise"}},
                {"Deadlift Day", new string[]{"Deadlift", "Front Squat", "Pull-up", "Glute Raise", "Face Pull"}},
            };
            List<WorkoutExercise> workoutExerciseEntities = new List<WorkoutExercise>();
            foreach (KeyValuePair<string, string[]> workout in workoutExerciseMapping)
            {
                Workout workoutEntity = workoutEntities.Find(x => x.WorkoutName == workout.Key);
                foreach (var (exercise, i) in workout.Value.Select((exercise, i) => (exercise, i)))
                {
                    workoutExerciseEntities.Add(new WorkoutExercise
                    {
                        WorkoutExerciseId = uniqueId++,
                        WorkoutId = workoutEntity.WorkoutId,
                        SequenceNum = i,
                        Exercise = exercise,
                        CreatedById = admin.UserId,
                        CreatedAt = now,
                        UpdatedById = admin.UserId,
                        UpdatedAt = now,
                    });
                }
            }
            modelBuilder.Entity<WorkoutExercise>().HasData(workoutExerciseEntities);

            // seed workout exercise details
            Dictionary<Dictionary<string, string>, dynamic> exerciseDetailMapping = new Dictionary<Dictionary<string, string>, dynamic>{
                {new Dictionary<string, string>{{"Bench Day", "Bench Press"}}, new {sets = 3, reps = 5, weight = 155, set_duration = 0}},
                {new Dictionary<string, string>{{"Bench Day", "Overhead Press"}}, new {sets = 3, reps = 8, weight = 85, set_duration = 0}},
                {new Dictionary<string, string>{{"Bench Day", "T-Bar Row"}}, new {sets = 3, reps = 8, weight = 100, set_duration = 0}},
                {new Dictionary<string, string>{{"Bench Day", "Tricep Pushdown"}}, new {sets = 3, reps = 8, weight = 35, set_duration = 0}},
                {new Dictionary<string, string>{{"Bench Day", "Dumbbell Bicep Curl"}}, new {sets = 3, reps = 8, weight = 30, set_duration = 0}},

                {new Dictionary<string, string>{{"Squat Day", "Squat"}}, new {sets = 3, reps = 5, weight = 185, set_duration = 0}},
                {new Dictionary<string, string>{{"Squat Day", "Romanian Deadlift"}}, new {sets = 3, reps = 8, weight = 95, set_duration = 0}},
                {new Dictionary<string, string>{{"Squat Day", "Lat Pull Down"}}, new {sets = 3, reps = 8, weight = 40, set_duration = 0}},
                {new Dictionary<string, string>{{"Squat Day", "Bulgarian Split Squat"}}, new {sets = 3, reps = 8, weight = 10, set_duration = 0}},
                {new Dictionary<string, string>{{"Squat Day", "Jump Rope"}}, new {sets = 3, reps = 0, weight = 0, set_duration = 30}},

                {new Dictionary<string, string>{{"Overhead Press Day", "Overhead Press"}}, new {sets = 3, reps = 5, weight = 95, set_duration = 0}},
                {new Dictionary<string, string>{{"Overhead Press Day", "Incline Bench Press"}}, new {sets = 3, reps = 8, weight = 85, set_duration = 0}},
                {new Dictionary<string, string>{{"Overhead Press Day", "Barbell Row"}}, new {sets = 3, reps = 8, weight = 95, set_duration = 0}},
                {new Dictionary<string, string>{{"Overhead Press Day", "Tricep Overhead Extension"}}, new {sets = 3, reps = 8, weight = 40, set_duration = 0}},
                {new Dictionary<string, string>{{"Overhead Press Day", "Dumbbell Lat Raise"}}, new {sets = 3, reps = 8, weight = 10, set_duration = 0}},

                {new Dictionary<string, string>{{"Deadlift Day", "Deadlift"}}, new {sets = 3, reps = 5, weight = 225, set_duration = 0}},
                {new Dictionary<string, string>{{"Deadlift Day", "Front Squat"}}, new {sets = 3, reps = 8, weight = 95, set_duration = 0}},
                {new Dictionary<string, string>{{"Deadlift Day", "Pull-up"}}, new {sets = 3, reps = 8, weight = 0, set_duration = 0}},
                {new Dictionary<string, string>{{"Deadlift Day", "Glute Raise"}}, new {sets = 3, reps = 8, weight = 95, set_duration = 0}},
                {new Dictionary<string, string>{{"Deadlift Day", "Face Pull"}}, new {sets = 3, reps = 8, weight = 30, set_duration = 0}},
            };
            List<WorkoutExerciseDetail> workoutExerciseDetailEntities = new List<WorkoutExerciseDetail>();
            foreach (KeyValuePair<Dictionary<string, string>, dynamic> exercise in exerciseDetailMapping)
            {
                // get workout name and exercise name from key
                string workoutName = exercise.Key.Keys.ToList()[0];
                string exerciseName = exercise.Key.Values.ToList()[0];

                // get set details
                dynamic setDetail = exercise.Value;

                // get workout and workout exercise entities
                Workout workoutEntity = workoutEntities.Find(x => x.WorkoutName == workoutName);
                WorkoutExercise workoutExerciseEntity = workoutExerciseEntities.Find(x => x.Exercise == exerciseName && x.WorkoutId == workoutEntity.WorkoutId);

                for (int i = 0; i < setDetail.sets; i++)
                {
                    workoutExerciseDetailEntities.Add(new WorkoutExerciseDetail
                    {
                        WorkoutExerciseDetailId = uniqueId++,
                        WorkoutExerciseId = workoutExerciseEntity.WorkoutExerciseId,
                        Set = i + 1,
                        Reps = setDetail.reps,
                        Weight = setDetail.weight,
                        SetDuration = setDetail.set_duration,
                        CreatedById = admin.UserId,
                        CreatedAt = now,
                        UpdatedById = admin.UserId,
                        UpdatedAt = now,
                    });
                }
            }
            modelBuilder.Entity<WorkoutExerciseDetail>().HasData(workoutExerciseDetailEntities);
        }

    }
}