using GymWorkout.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymWorkout.Infrastructure.Persistance.Configuration
{
    public class ParticipantConfiguration : IEntityTypeConfiguration<Participant>
    {
        public void Configure(EntityTypeBuilder<Participant> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(150).IsRequired();
            builder.Property(p => p.Surname).HasMaxLength(150);
            builder.HasMany(p => p.MyTreningDays)
                   .WithOne(m => m.Participant)
                   .HasForeignKey(m => m.ParticipantId);
        }
    }
}
