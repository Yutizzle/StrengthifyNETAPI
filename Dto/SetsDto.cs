namespace StrengthifyNETAPI.Dto
{
    public class SetsDto
    {
        public int ExerciseId {get; set;}
        public int Set {get; set;}
         public int Reps {get; init;}
         public int Weight {get; init;}
         public int SetDuration {get; init;}
         public int SetRestDuration {get; init;}
         public int MaxReps {get; init;}
         public int MaxWeight {get; init;}
         public int MaxSetDuration {get; init;}
         public string RepsIncrementFrequency {get; init;}
         public string WeightIncrementFrequency {get; init;}
         public string SetDurationIncrementFrequency {get; init;}
         public int RepsIncrementAmount {get; init;}
         public int WeightIncrementAmount {get; init;}
         public int SetDurationIncrementAmount {get; init;}
         public string Exercise {get; init;}
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