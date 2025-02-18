using Microsoft.EntityFrameworkCore;

using NotificationManager.Infrastructure;

namespace TransverseApiSessionCDR.Infrastructure
{
    /// <summary>
    /// A utiliser que pour les migrations
    /// </summary>
    public class MigrationContext : BddContexte
    {
        public MigrationContext() : base()
        {
            Database.SetCommandTimeout(150000);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=TESTJVI;Trusted_Connection=True;");
        }
    }
}
