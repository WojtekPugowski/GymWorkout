using GymWorkout.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GymWorkout.Infrastructure.Persistance
{
    public static class SqlDatabaseConfiguration
    {
        public static void AddSqlDatabase(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<IApplicationDbContext, MainDbContext>(options =>
                options.UseSqlServer(connectionString));
        }

    }
}
