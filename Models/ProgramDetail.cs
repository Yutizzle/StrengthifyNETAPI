using System;

namespace Strengthify.Models
{
    public record ProgramDetail {
         public int Id {get; init;}
         public int ProgramId {get; init;}
         public int WorkoutId {get; init;}
         public int SequenceNum {get; init;}
         public int CycleDayNum {get; init;}
         public Guid CreatedBy {get; init;}
         public DateTimeOffset CreatedAt {get; init;}
         public Guid UpdatedBy {get; init;}
         public DateTimeOffset UpdatedAt{get; init;}
    }
}