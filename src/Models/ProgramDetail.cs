using System;
using Microsoft.EntityFrameworkCore;

namespace StrengthifyNETAPI.Models
{
    [Index(nameof(ProgramDetailId), nameof(ProgramId), nameof(WorkoutId), IsUnique = true)]
    public class ProgramDetail : BaseEntity
    {
        public int ProgramDetailId { get; set; }
        public int SequenceNum { get; set; }
        public int CycleDayNum { get; set; }

        public int ProgramId { get; set; }
        public Program Program { get; set; }
        public int WorkoutId { get; set; }
        public Workout Workout { get; set; }
    }
}