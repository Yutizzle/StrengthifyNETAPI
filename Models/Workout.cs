using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Strengthify.Models
{
    [Index(nameof(WorkoutName), IsUnique = true)]
    public record Workout {
         public int WorkoutId {get; init;}
         public Guid ImageObjectId {get; init;}
         public string WorkoutName {get; init;}
         public User CreatedBy {get; init;}
         public DateTimeOffset CreatedAt {get; init;}
         public User UpdatedBy {get; init;}
         public DateTimeOffset UpdatedAt{get; init;}
         
         public ICollection<WorkoutExercise> WorkoutExercises {get; init;}
    }
}