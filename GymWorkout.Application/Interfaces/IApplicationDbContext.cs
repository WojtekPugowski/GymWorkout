﻿using GymWorkout.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GymWorkout.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<TrainingDay> TrainingDays { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<ExerciseVariables> ExerciseVariables { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        //void TrainingDays();
    }
}
