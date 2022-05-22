using System;
using System.Collections.Generic;
using StrengthifyNETAPI.Models;

namespace StrengthifyNETAPI.Tests
{
    public static class Utilities
    {
        public static void InitializeDbForTests(StrengthifyContext db)
        {
            db.Users.AddRange(GetSeedingMessages());
            db.Programs.Add(GetSeedingProgram());
            db.Workouts.Add(GetSeedingWorkout());
            db.ProgramDetails.Add(GetSeedingProgramDetail());
            db.WorkoutExercises.Add(GetSeedingWorkoutExercise());
            db.WorkoutExerciseDetails.Add(GetSeedingWorkoutExerciseDetail());
            db.SaveChanges();
        }

        public static void ReinitializeDbForTests(StrengthifyContext db)
        {
            db.Users.RemoveRange(db.Users);
            InitializeDbForTests(db);
        }

        public static List<User> GetSeedingMessages()
        {
            return new List<User>()
            {
                new User() {
                    Uuid = new Guid("29ed5754-b19a-41fb-a902-6503717850a1"),
                    FirstName = "Admin1",
                    LastName = "Admin1",
                    DateOfBirth = new DateTime(1994, 02, 03),
                    Email = "admin1@admin.com",
                    ProgramRun = 0,
                    ProgramId = 0
                },
                new User() {
                    Uuid = new Guid("37e9433e-3cfe-43bf-a26e-82f41cc20dbc"),
                    FirstName = "Admin2",
                    LastName = "Admin2",
                    DateOfBirth = new DateTime(1994, 02, 03),
                    Email = "admin2@admin.com",
                    ProgramRun = 0,
                    ProgramId = 0
                }
            };
        }

        public static Program GetSeedingProgram()
        {
            return new Program
            {
                ProgramId = 1,
                ProgramName = "Program 1",
                TotalCycleDays = 1
            };
        }
        public static Workout GetSeedingWorkout()
        {
            return new Workout
            {
                WorkoutId = 2,
                WorkoutName = "Workout 1",

            };
        }
        public static ProgramDetail GetSeedingProgramDetail()
        {
            return new ProgramDetail
            {
                ProgramId = 1,
                WorkoutId = 2,
                SequenceNum = 0,
                CycleDayNum = 1
            };
        }
        public static WorkoutExercise GetSeedingWorkoutExercise()
        {
            return new WorkoutExercise
            {
                WorkoutExerciseId = 3,
                WorkoutId = 2,
                Exercise = "Exercise 1",
                SequenceNum = 0
            };
        }
        public static WorkoutExerciseDetail GetSeedingWorkoutExerciseDetail()
        {
            return new WorkoutExerciseDetail
            {
                WorkoutExerciseDetailId = 4,
                WorkoutExerciseId = 3,
                Set = 1
            };
        }
    }
}