using GymWorkout.Domain.Common;

namespace GymWorkout.Domain.Entities
{
    public class Participant : DomainEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Weight { get; set; }
        public int Growth { get; set; }
        public Coach? Coach { get; set; }
        public int CoachId { get; set; }
        public List<TrainingDay> MyTrenings { get; set; } = new List<TrainingDay>();

    }
}
