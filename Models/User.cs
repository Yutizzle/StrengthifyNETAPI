using System;
using Microsoft.EntityFrameworkCore;

namespace Strengthify.Models
{
    [Index(nameof(Uuid), IsUnique = true)]
    public record User {
         public int Id {get; init;}
         public Guid Uuid {get; init;}
         public string FirstName {get; init;}
         public string LastName {get; init;}
         public DateTimeOffset DateOfBirth {get; init;}
         public string Email {get; init;}
         public int ProgramId {get; init;}
         public int CurrentWorkoutId {get; init;}
         public int ProgramRun {get; init;}
         public Guid CreatedBy {get; init;}
         public DateTimeOffset CreatedAt {get; init;}
         public Guid UpdatedBy {get; init;}
         public DateTimeOffset UpdatedAt {get; init;}
    }
}