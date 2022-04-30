using System;
using Microsoft.EntityFrameworkCore;

namespace Strengthify.Models
{
    [Index(nameof(Uuid), IsUnique = true)]
    public record User {
         public int UserId {get; set;}
         public Guid Uuid {get; set;}
         public string FirstName {get; set;}
         public string LastName {get; set;}
         public DateTimeOffset DateOfBirth {get; set;}
         public string Email {get; set;}
         public int ProgramRun {get; set;}
         public Guid CreatedBy {get; set;}
         public DateTimeOffset CreatedAt {get; set;}
         public Guid UpdatedBy {get; set;}
         public DateTimeOffset UpdatedAt {get; set;}

         
         public int ProgramId {get; set;}
         public Program Program {get; set;}
         public int WorkoutId {get; set;}
         public Workout Workout {get; set;}
    }
}