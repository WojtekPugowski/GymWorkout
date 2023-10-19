using GymWorkout.Domain.Common;

namespace GymWorkout.Domain.Entities
{
    public abstract class Exercise : DomainEntity
    {
        public string Title { get; set; } = string.Empty;

        public ExercisesVariables ExercisesPlanned { get; set; } = new ExercisesVariables();

        public ExercisesVariables ExercisesDone { get; set; } = new(); //new way to init
        public TrainingDay TrainingDay { get; set; } = new();
        public int TrainingDayId { get; set; }

    }

}
