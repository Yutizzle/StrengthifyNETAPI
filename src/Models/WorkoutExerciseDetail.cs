using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace StrengthifyNETAPI.Models
{
    [Index(nameof(WorkoutExerciseDetailId), nameof(WorkoutExerciseId), nameof(Set), IsUnique = true)]
    public class WorkoutExerciseDetail : BaseEntity
    {
        public int WorkoutExerciseDetailId { get; set; }
        public int Set { get; set; }
        public int Reps { get; set; }
        public int Weight { get; set; }
        public int SetDuration { get; set; }
        public int SetRestDuration { get; set; }
        public int MaxReps { get; set; }
        public int MaxWeight { get; set; }
        public int MaxSetDuration { get; set; }
        public int RepsIncrementAmount { get; set; }
        public int WeightIncrementAmount { get; set; }
        public int SetDurationIncrementAmount { get; set; }
        public int? RepsIncrementFrequencyId { get; set; }
        public IncrementFrequency RepsIncrementFrequency { get; set; }
        public int? WeightIncrementFrequencyId { get; set; }
        public IncrementFrequency WeightIncrementFrequency { get; set; }
        public int? SetDurationIncrementFrequencyId { get; set; }
        public IncrementFrequency SetDurationIncrementFrequency { get; set; }
        public int WorkoutExerciseId { get; set; }
        public WorkoutExercise WorkoutExercise { get; set; }
    }
}