using System;

namespace StrengthifyNETAPI.Dto
{
    public class ProgramReadFullDto
    {
        public int ProgramId { get; set; }
        public string ProgramName { get; set; }
        public int TotalCycleDays { get; set; }
        public WorkoutUpdateDto[] Workouts { get; set; }
        public ExerciseUpdateDto[] Exercises { get; set; }
        public SetUpdateDto[] Sets { get; set; }
    }
}