using System;

namespace StrengthifyNETAPI.Dto
{
    public class ProgramUpdateDto
    {
        public int ProgramId { get; set; }
        public string ProgramName { get; set; }
        public WorkoutUpdateDto[] Workouts { get; set; }
        public ExerciseUpdateDto[] Exercises { get; set; }
        public SetUpdateDto[] Sets { get; set; }
        public Guid UserUuid { get; set; }
    }
}

/*

external contract:

{
    id: number,
    programName: string,
    workouts: [
        {
            id: number,
            workoutName: string
        }
    ],
    exercises: [
        {
            id: number,
            workoutId: number,
            exercise: string
        }
    ],
    sets: [
        {
            exerciseId: number,
            set: number,
            reps: number,
            weight: number,
            ...
            ...
            ...
        }
    ]

}

*/