using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Strengthify.Models;

namespace Strengthify.Models
{
    [Index(nameof(WorkoutName), IsUnique = true)]
    public record Workout {
         public int Id {get; init;}
         public Guid ImageObjectId {get; init;}
         public string WorkoutName {get; init;}
         public Guid CreatedBy {get; init;}
         public DateTimeOffset CreatedAt {get; init;}
         public Guid UpdatedBy {get; init;}
         public DateTimeOffset UpdatedAt{get; init;}
         public ICollection<WorkoutExercise> WorkoutExercises {get; init;}
    }
}