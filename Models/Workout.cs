using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Strengthify.Models
{
    [Index(nameof(WorkoutName), IsUnique = true)]
    public class Workout : BaseEntity
    {
        public int WorkoutId { get; init; }
        public Guid? ImageObjectId { get; init; }
        public string WorkoutName { get; init; }
        public ICollection<WorkoutExercise> WorkoutExercises { get; init; }
    }
}