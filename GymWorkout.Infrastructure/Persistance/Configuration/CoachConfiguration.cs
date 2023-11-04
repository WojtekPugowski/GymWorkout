using GymWorkout.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymWorkout.Infrastructure.Persistance.Configuration
{
    public class CoachConfiguration : IEntityTypeConfiguration<Coach>
    {
        public void Configure(EntityTypeBuilder<Coach> builder)
        {
            //builder.ToTable(nameof(Coach));
            //builder.HasKey(c => c.Id);
            builder.Property(c => c.Name);
            builder.Property(c => c.Surname);

            builder.HasMany(c => c.Participants)
                    .WithOne(p => p.Coach)
                    .HasForeignKey(p => p.CoachId)
                    .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
