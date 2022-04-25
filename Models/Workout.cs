using System;
using System.Collections.Generic;
using Strengthify.Models;

namespace Strengthify.Models
{
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