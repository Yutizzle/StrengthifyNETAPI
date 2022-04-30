using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Strengthify.Models
{
    [Index(nameof(ProgramId), nameof(WorkoutId), IsUnique = true)]
    public record ProgramDetail {
         public int ProgramDetailId {get; set;}
         public int SequenceNum {get; set;}
         public int CycleDayNum {get; set;}
         public User CreatedBy {get; set;}
         public DateTimeOffset CreatedAt {get; set;}
         public User UpdatedBy {get; set;}
         public DateTimeOffset UpdatedAt{get; set;}

         public int ProgramId {get; set;}
         public Program Program {get; set;}
         public int WorkoutId {get; set;}
         public Workout Workout {get; set;}
    }
}