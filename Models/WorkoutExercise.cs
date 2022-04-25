using System;

namespace Strengthify.Models
{
    public record WorkoutExercise {
         public int Id {get; init;}
         public int WorkoutId {get; init;}
         public int SequenceNum {get; init;}
         public string Exercise {get; init;}
         public Guid CreatedBy {get; init;}
         public DateTimeOffset CreatedAt {get; init;}
         public Guid UpdatedBy {get; init;}
         public DateTimeOffset UpdatedAt{get; init;}
    }
}