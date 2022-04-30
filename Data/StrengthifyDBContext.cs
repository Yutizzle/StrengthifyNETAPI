using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
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
            foreach(var entity in entities)
            {
                var now = DateTime.UtcNow;
                if(entity.State == EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).CreatedAt = now;
                }
                ((BaseEntity)entity.Entity).UpdatedAt = now;
            }
        }   

    }
}