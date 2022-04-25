using System;

namespace Strengthify.Models
{
    public record WorkoutExerciseDetail {
         public int Id {get; init;}
         public int WorkoutExerciseId {get; init;}
         public int Set {get; init;}
         public int Reps {get; init;}
         public int Weight {get; init;}
         public int SetDuration {get; init;}
         public int SetRestDuration {get; init;}
         public int MaxReps {get; init;}
         public int MaxWeight {get; init;}
         public int MaxSetDuration {get; init;}
         public int RepsIncrementFrequencyId {get; init;}
         public int WeightIncrementFrequencyId {get; init;}
         public int SetDurationIncrementFrequencyId {get; init;}
         public int RepsIncrementAmount {get; init;}
         public int WeightIncrementAmount {get; init;}
         public int SetDurationIncrementAmount {get; init;}
         public string Exercise {get; init;}
         public Guid CreatedBy {get; init;}
         public DateTimeOffset CreatedAt {get; init;}
         public Guid UpdatedBy {get; init;}
         public DateTimeOffset UpdatedAt{get; init;}
    }
}