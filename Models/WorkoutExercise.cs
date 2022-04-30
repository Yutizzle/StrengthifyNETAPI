using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Strengthify.Models
{
    [Index(nameof(WorkoutId), nameof(Exercise), IsUnique = true)]
    public record WorkoutExercise {
         public int WorkoutExerciseId {get; set;}
         public int SequenceNum {get; set;}
         public string Exercise {get; set;}
         public User CreatedBy {get; set;}
         public DateTimeOffset CreatedAt {get; set;}
         public User UpdatedBy {get; set;}
         public DateTimeOffset UpdatedAt{get; set;}

         public ICollection<WorkoutExerciseDetail> WorkoutExerciseDetails {get; set;}
         public int WorkoutId {get; set;}
         public Workout Workout {get; set;}
    }
}