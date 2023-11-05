using GymWorkout.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
