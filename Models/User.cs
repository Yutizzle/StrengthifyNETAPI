using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Strengthify.Models
{
    [Index(nameof(UserId), IsUnique = true)]
    public record User {
         public int UserId {get; set;}
         public Guid Uuid {get; set;}
         public string FirstName {get; set;}
         public string LastName {get; set;}
         public DateTimeOffset DateOfBirth {get; set;}
         public string Email {get; set;}
         public int ProgramRun {get; set;}
         public int CreatedById {get; set;}
         [ForeignKey("CreatedById")]
         public User CreatedBy {get; set;}
         public DateTimeOffset CreatedAt {get; set;}
         public int UpdatedById {get; set;}
         [ForeignKey("UpdatedById")]
         public User UpdatedBy {get; set;}
         public DateTimeOffset UpdatedAt {get; set;}

         
         public int ProgramId {get; set;}
         public Program Program {get; set;}
         public int WorkoutId {get; set;}
         public Workout Workout {get; set;}
         [InverseProperty("CreatedBy")]
         public ICollection<IncrementFrequency> IncrementFrequencyCreated {get; set;}
         [InverseProperty("UpdatedBy")]
         public ICollection<IncrementFrequency> IncrementFrequencyUpdated {get; set;}
         [InverseProperty("CreatedBy")]
         public ICollection<Program> ProgramCreated {get; set;}
         [InverseProperty("UpdatedBy")]
         public ICollection<Program> ProgramUpdated {get; set;}
         [InverseProperty("CreatedBy")]
         public ICollection<ProgramDetail> ProgramDetailCreated {get; set;}
         [InverseProperty("UpdatedBy")]
         public ICollection<ProgramDetail> ProgramDetailUpdated {get; set;}
         [InverseProperty("CreatedBy")]
         public ICollection<Workout> WorkoutCreated {get; set;}
         [InverseProperty("UpdatedBy")]
         public ICollection<Workout> WorkoutUpdated {get; set;}
         [InverseProperty("CreatedBy")]
         public ICollection<WorkoutExercise> WorkoutExerciseCreated {get; set;}
         [InverseProperty("UpdatedBy")]
         public ICollection<WorkoutExercise> WorkoutExerciseUpdated {get; set;}
         [InverseProperty("CreatedBy")]
         public ICollection<WorkoutExerciseDetail> WorkoutExerciseDetailCreated {get; set;}
         [InverseProperty("UpdatedBy")]
         public ICollection<WorkoutExerciseDetail> WorkoutExerciseDetailUpdated {get; set;}
    }
}