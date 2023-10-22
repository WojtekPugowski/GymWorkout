using GymWorkout.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymWorkout.Infrastructure.Persistance.Configuration
{
    public class TrainingDayConfiguration : IEntityTypeConfiguration<TrainingDay>
    {
        public void Configure(EntityTypeBuilder<TrainingDay> builder)
        {
            builder.ToTable(nameof(TrainingDay));
            builder.HasKey(t => t.Id);
            builder.Property(t => t.DateAndTime);

            builder.HasMany(t => t.Exercises)
                    .WithOne(t => t.TrainingDay)
                    .HasForeignKey(t => t.TrainingDayId)
                    .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
