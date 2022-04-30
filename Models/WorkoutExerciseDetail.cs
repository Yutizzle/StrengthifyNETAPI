using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Strengthify.Models
{
    [Index(nameof(WorkoutExerciseId), nameof(Set), IsUnique = true)]
    public class WorkoutExerciseDetail : BaseEntity {
         public int WorkoutExerciseDetailId {get; set;}
         public int Set {get; set;}
         public int Reps {get; set;}
         public int Weight {get; set;}
         public int SetDuration {get; set;}
         public int SetRestDuration {get; set;}
         public int MaxReps {get; set;}
         public int MaxWeight {get; set;}
         public int MaxSetDuration {get; set;}
         public int RepsIncrementAmount {get; set;}
         public int WeightIncrementAmount {get; set;}
         public int SetDurationIncrementAmount {get; set;}
         
         public IncrementFrequency RepsIncrementFrequency {get; set;}
         public IncrementFrequency WeightIncrementFrequency {get; set;}
         public IncrementFrequency SetDurationIncrementFrequency {get; set;}
         public string Exercise {get; set;}   
         public int WorkoutExerciseId {get; set;}
         public WorkoutExercise WorkoutExercise {get; set;}
    }
}