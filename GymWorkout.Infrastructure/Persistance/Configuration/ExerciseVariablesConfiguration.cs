using GymWorkout.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymWorkout.Infrastructure.Persistance.Configuration
{
    public class ExerciseVariablesConfiguration : IEntityTypeConfiguration<ExerciseVariables>
    {
        public void Configure(EntityTypeBuilder<ExerciseVariables> builder)
        {
            builder.Property(b => b.NumberOfSeries);
            builder.Property(b => b.WeightLifted);
            builder.Property(b => b.Duration);
        }
    }
}
