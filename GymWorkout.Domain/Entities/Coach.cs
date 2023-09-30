using GymWorkout.Domain.Common;

namespace GymWorkout.Domain.Entities
{
    public class Coach : DomainEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Participant> Participants { get; set; } = new List<Participant>();
    }
}
