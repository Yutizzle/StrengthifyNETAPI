using System;

namespace StrengthifyNETAPI.Dto
{
    public class ProgramReadFullDto
    {
        public int ProgramId { get; set; }
        public string ProgramName { get; set; }
        public int TotalCycleDays { get; set; }
        public WorkoutDto[] Workouts { get; set; }
        public ExerciseDto[] Exercises { get; set; }
        public SetDto[] Sets { get; set; }
    }
}