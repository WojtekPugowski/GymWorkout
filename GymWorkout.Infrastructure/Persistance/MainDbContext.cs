using GymWorkout.Application.Interfaces;
using GymWorkout.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GymWorkout.Infrastructure.Persistance
{
    public class MainDbContext : DbContext, IApplicationDbContext
    {
        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
        {

        }
        public DbSet<Coach> Coachs { get; set; }
        public DbSet<Participant> Participats { get; set; }
        public DbSet<TrainingDay> TrainingDays { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<ExerciseVariables> ExerciseVariables { get; set; }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder //fluentAPI
               .Properties<decimal>()
               .HavePrecision(18, 4);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Coach>()
                .HasMany(c => c.Participants)
                .WithOne(p => p.Coach)
                .HasForeignKey(p => p.CoachId);

            modelBuilder.Entity<Participant>()
                .HasMany(p => p.MyTreningDays)
                .WithOne(m => m.Participant)
                .HasForeignKey(m => m.ParticipantId);

            modelBuilder.Entity<TrainingDay>()
                .HasMany(t => t.Exercises)
                .WithOne(e => e.TrainingDay)
                .HasForeignKey(e => e.TrainingDayId);

            modelBuilder.Entity<Exercise>()
                .HasOne(e => e.ExercisePlanned)
                .WithOne()
                .HasForeignKey<Exercise>(ev => ev.ExercisePlannedId);

            modelBuilder.Entity<Exercise>()
                .HasOne(e => e.ExerciseDone)
                .WithOne()
                .HasForeignKey<Exercise>(ev => ev.ExerciseDoneId);
        }
    }
}
