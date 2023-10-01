using GymWorkout.Domain.Common;

namespace GymWorkout.Domain.Entities
{
    public abstract class Exercise : DomainEntity
    {
        public string Title { get; set; } = string.Empty;
        public int NumberOfSeries { get; set; }
        public int NumberOfRepetitions { get; set; }
        public int WeightLifted { get; set; } //gram
        public int Duration { get; set; } //second
    }

}
