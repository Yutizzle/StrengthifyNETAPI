using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StrengthifyNETAPI.Models
{
    [Index(nameof(WorkoutId), IsUnique = true)]
    public class Workout : BaseEntity
    {
        public int WorkoutId { get; set; }
        public Guid? ImageObjectId { get; set; }
        public string WorkoutName { get; set; }
        public ICollection<WorkoutExercise> WorkoutExercises { get; set; }
    }
}