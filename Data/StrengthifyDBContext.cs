using Microsoft.EntityFrameworkCore;
using Strengthify.Models;

namespace Strengthify
{
    public class StrengthifyContext : DbContext
    {
        public StrengthifyContext (DbContextOptions<StrengthifyContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users {get; set;}
        public DbSet<IncrementFrequency> IncrementFrequencies {get; set;}
        public DbSet<Program> Programs {get; set;}
        public DbSet<ProgramDetail> ProgramDetails {get; set;}
        public DbSet<Workout> Workouts {get; set;}
        public DbSet<WorkoutExercise> WorkoutExercises {get; set;}
        public DbSet<WorkoutExerciseDetail> WorkoutExerciseDetails {get; set;}

    }
}