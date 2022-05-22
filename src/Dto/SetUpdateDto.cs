namespace StrengthifyNETAPI.Dto
{
    public class SetUpdateDto
    {
        public int WorkoutExerciseDetailId { get; set; }
        public string WorkoutKey { get; set; }
        public string ExerciseKey { get; set; }
        public int Set { get; set; }
        public int Reps { get; set; }
        public int Weight { get; set; }
        public int SetDuration { get; set; }
        public int SetRestDuration { get; set; }
        public int MaxReps { get; set; }
        public int MaxWeight { get; set; }
        public int MaxSetDuration { get; set; }
        public int RepsIncrementFrequencyId { get; set; }
        public int WeightIncrementFrequencyId { get; set; }
        public int SetDurationIncrementFrequencyId { get; set; }
        public int RepsIncrementAmount { get; set; }
        public int WeightIncrementAmount { get; set; }
        public int SetDurationIncrementAmount { get; set; }
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