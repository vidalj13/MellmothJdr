using MellmothJdr.Services.IServices;
using MellmothJdr.Services.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServicesModule
    {
        public static IServiceCollection AddServices(
            this IServiceCollection services,
            string connectionString,
            int _dbConnectionMaxRetryCount = 10,
            int _dbConnectionMaxRetryDelay = 1)
        {
            services
                .AddScoped<IUsersService, UsersService>()
                .AddScoped<IJeuService, JeuService>()
                .AddScoped<IRaceService, RaceService>()
                .AddScoped<IClasseService, ClasseService>()
                .AddDAL(connectionString,
                            _dbConnectionMaxRetryCount,
                             _dbConnectionMaxRetryDelay);
            return services;
        }
    }
}
