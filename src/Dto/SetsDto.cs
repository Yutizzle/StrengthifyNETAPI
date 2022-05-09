namespace StrengthifyNETAPI.Dto
{
    public class SetsDto
    {
        public string ExerciseKey { get; init; }
        public int Set { get; set; }
        public int Reps { get; init; }
        public int Weight { get; init; }
        public int SetDuration { get; init; }
        public int SetRestDuration { get; init; }
        public int MaxReps { get; init; }
        public int MaxWeight { get; init; }
        public int MaxSetDuration { get; init; }
        public int RepsIncrementFrequencyId { get; init; }
        public int WeightIncrementFrequencyId { get; init; }
        public int SetDurationIncrementFrequencyId { get; init; }
        public int RepsIncrementAmount { get; init; }
        public int WeightIncrementAmount { get; init; }
        public int SetDurationIncrementAmount { get; init; }
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