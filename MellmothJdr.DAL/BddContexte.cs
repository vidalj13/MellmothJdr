using MellmothJdr.DAL.Entities;
using MellmothJdr.DAL.Entities.FichesPersos;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

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
        public DbSet<Jeu> Jeux { get; set; }
        public DbSet<Partie> Parties { get; set; }
    }
}
