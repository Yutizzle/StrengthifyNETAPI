using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StrengthifyNETAPI.Models
{
    [Index(nameof(WorkoutExerciseId), nameof(WorkoutId), IsUnique = true)]
    public class WorkoutExercise : BaseEntity
    {
        public int WorkoutExerciseId { get; set; }
        public int SequenceNum { get; set; }
        public string Exercise { get; set; }

        public ICollection<WorkoutExerciseDetail> WorkoutExerciseDetails { get; set; }
        public int WorkoutId { get; set; }
        public Workout Workout { get; set; }
    }
}