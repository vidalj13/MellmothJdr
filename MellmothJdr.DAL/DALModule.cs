using Microsoft.EntityFrameworkCore;

using NotificationManager.Infrastructure;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DALModule
    {
        public static IServiceCollection AddDAL(
            this IServiceCollection services,
            string connectionString,
            int _dbConnectionMaxRetryCount = 10,
            int _dbConnectionMaxRetryDelay = 1)
        {
            services.AddDbContext<BddContexte>(x =>
            {
                x.UseSqlServer(connectionString,
                    options => options.EnableRetryOnFailure(
                        maxRetryCount: _dbConnectionMaxRetryCount,
                        maxRetryDelay: TimeSpan.FromSeconds(_dbConnectionMaxRetryDelay),
                        errorNumbersToAdd: null
                    )
                );
#if DEBUG
                x.EnableSensitiveDataLogging();
#endif
            });
            return services;
        }
    }
}
