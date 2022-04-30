using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Strengthify.Models
{
    [Index(nameof(WorkoutId), nameof(Exercise), IsUnique = true)]
    public record WorkoutExercise {
         public int WorkoutExerciseId {get; set;}
         public int SequenceNum {get; set;}
         public string Exercise {get; set;}
         public Guid CreatedBy {get; set;}
         public DateTimeOffset CreatedAt {get; set;}
         public Guid UpdatedBy {get; set;}
         public DateTimeOffset UpdatedAt{get; set;}

         public ICollection<WorkoutExerciseDetail> WorkoutExerciseDetails {get; set;}
         public int WorkoutId {get; set;}
         public Workout Workout {get; set;}
    }
}