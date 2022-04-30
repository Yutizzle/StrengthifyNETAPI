using System;

namespace StrengthifyNETAPI.Dto
{
    public class ProgramWriteDto
    {
        public int Id {get; set;}
        public string ProgramName {get; set;}
        public WorkoutDto[] Workouts {get; set;}
        public ExerciseDto[] Exercises {get; set;}
        public SetsDto[] Sets {get; set;}
        public Guid UserId {get; set;}
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