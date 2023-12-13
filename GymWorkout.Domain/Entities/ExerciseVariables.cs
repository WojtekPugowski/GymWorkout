using GymWorkout.Domain.Common;

namespace GymWorkout.Domain.Entities
{
    public class ExerciseVariables : DomainEntity //dodać DB (ewentualnie można zapisać do JSON)
    {
        public int NumberOfSeries { get; set; }
        public int NumberOfRepetitions { get; set; }
        public int WeightLifted { get; set; } //gram
        public int Duration { get; set; } //second
    }
}
