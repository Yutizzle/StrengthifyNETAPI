using System;
using Microsoft.EntityFrameworkCore;

namespace Strengthify.Models
{
    [Index(nameof(WorkoutExerciseId), nameof(Set), IsUnique = true)]
    public record WorkoutExerciseDetail {
         public int WorkoutExerciseDetailId {get; set;}
         public int Set {get; set;}
         public int Reps {get; set;}
         public int Weight {get; set;}
         public int SetDuration {get; set;}
         public int SetRestDuration {get; set;}
         public int MaxReps {get; set;}
         public int MaxWeight {get; set;}
         public int MaxSetDuration {get; set;}
         public int RepsIncrementFrequencyId {get; set;}
         public int WeightIncrementFrequencyId {get; set;}
         public int SetDurationIncrementFrequencyId {get; set;}
         public int RepsIncrementAmount {get; set;}
         public int WeightIncrementAmount {get; set;}
         public int SetDurationIncrementAmount {get; set;}
         public string Exercise {get; set;}
         public Guid CreatedBy {get; set;}
         public DateTimeOffset CreatedAt {get; set;}
         public Guid UpdatedBy {get; set;}
         public DateTimeOffset UpdatedAt{get; set;}

         
         public int WorkoutExerciseId {get; set;}
         public WorkoutExercise WorkoutExercise {get; set;}
    }
}