using GymWorkout.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GymWorkout.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        public DbSet<Coach> Coachs { get; set; }
        public DbSet<Participant> Participats { get; set; }
        public DbSet<TrainingDay> TrainingDays { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);


    }
}
