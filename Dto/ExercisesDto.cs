namespace StrengthifyNETAPI.Dto
{
    public class ExerciseDto
    {
        public int Id {get; set;}
        public int WorkoutId {get; set;}
        public string Exercise {get; set;}

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