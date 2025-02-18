using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using NotificationManager.Infrastructure.Entities;

using TransverseApiSessionCDR.Infrastructure;

namespace NotificationManager.Infrastructure
{
    public class BddContexte : DBContexteBase
    {
        public BddContexte(DbContextOptions options, ILogger<BddContexte> logger) : base(options, logger) { }
        public BddContexte()
            : base()
        { }

        public DbSet<User> Users { get; set; }
    }
}
