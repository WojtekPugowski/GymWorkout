using GymWorkout.Domain.Common;

namespace GymWorkout.Domain.Entities
{
    public class Participant : DomainEntity
    {
        public int ParticipantId { get; set; }
        public int CoachId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Surname { get; set; }
        public int Weight { get; set; }
        public int Growth { get; set; }
        public List<TrainingDay> MyTrenings { get; set; } = new List<TrainingDay>();

    }
}
