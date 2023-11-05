using GymWorkout.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymWorkout.Infrastructure.Persistance.Configuration
{
    public class ExerciseConfiguration : IEntityTypeConfiguration<Exercise>
    {
        public void Configure(EntityTypeBuilder<Exercise> builder)
        {
            builder.Property(b => b.Title);
            builder.HasOne(b => b.ExercisePlanned)
                    .WithOne()
                    .HasForeignKey<Exercise>(ev => ev.ExercisePlannedId)
                    .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(b => b.ExerciseDone)
                    .WithOne()
                   .HasForeignKey<Exercise>(ev => ev.ExerciseDoneId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
