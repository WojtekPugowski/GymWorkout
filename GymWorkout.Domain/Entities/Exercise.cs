using GymWorkout.Domain.Common;

namespace GymWorkout.Domain.Entities
{
    public class Exercise : DomainEntity
    {
        public string Title { get; set; } = string.Empty;

        public ExerciseVariables ExercisePlanned { get; set; } = new ExerciseVariables();
        public int ExercisePlannedId { get; set; }
        public ExerciseVariables ExerciseDone { get; set; } = new(); //new way to init
        public int ExerciseDoneId { get; set; }

        public TrainingDay TrainingDay { get; set; } = new();
        public int TrainingDayId { get; set; }

    }

}
