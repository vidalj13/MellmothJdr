using Microsoft.Extensions.DependencyInjection;

using NotificationManager.Infrastructure;

namespace MellmothJdr.Services.Services
{
    public class ServiceBase
    {
        private readonly IServiceScopeFactory _scopeFactory;
        public ServiceBase(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
        }

        protected BddContexte GetScopedBddContexte()
        {
            return _scopeFactory.CreateScope().ServiceProvider.GetService<BddContexte>();
        }
    }
}