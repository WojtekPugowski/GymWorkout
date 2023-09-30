using GymWorkout.Domain.Common;

namespace GymWorkout.Domain.Entities
{
    public class TrainingDay : DomainEntity
    {
        public DateTimeOffset DateAndTime { get; set; } //w T-Sql - DateTimeOffset - parameter 7
        public Participant Participant { get; set; } = new Participant();
        public List<Exercise> Exercises { get; set; } = new List<Exercise>();
    }
}
