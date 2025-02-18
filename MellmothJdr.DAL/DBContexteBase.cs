using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Logging;

using NotificationManager.Infrastructure;
using NotificationManager.Infrastructure.Entities.Base;

namespace TransverseApiSessionCDR.Infrastructure
{
    public class DBContexteBase : DbContext
    {
        protected bool _allEnumAsString { get; }
        protected ILogger<BddContexte> Logger { get; }
        public DBContexteBase(DbContextOptions options, ILogger<BddContexte> logger)
            : base(options)
        {
            Logger = logger;
            _allEnumAsString = true;
        }

        public DBContexteBase()
            : base()
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.AddInterceptors(new EFCommandInterceptor(Logger));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            if (_allEnumAsString)
            {
                modelBuilder.SaveEnumAsString();
            }
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                return await base
                    .SaveChangesAsync(cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (DbUpdateException ex)
            {
                foreach (EntityEntry result in ex.Entries)
                {
                    if (result.State == EntityState.Added)
                    {
                        Logger.LogError("{Message}", $"Entity of type '{result.Entity.GetType()}' cannot be added");
                    }
                    else
                    {
                        Logger.LogError("{Message}", $"Entity of type '{result.Entity.GetType()}' cannot be updated with values :");
                        foreach (string propertyName in result.OriginalValues.Properties.Select(x => x.Name))
                        {
                            Logger.LogError("{Message}", $"- Property: '{result.OriginalValues[propertyName]}' -> '{result.CurrentValues[propertyName]}'");
                        }
                    }
                }

                throw;
            }
        }
        protected virtual void PopulateBaseInformations()
        {
            // Récupère les entités qui doivent être créées
            IEnumerable<BaseEntity> addEntities = ChangeTracker.Entries()
                                                           .Where(e => e.Entity is BaseEntity && e.State == EntityState.Added)
                                                           .Select(c => c.Entity as BaseEntity);

            foreach (BaseEntity entity in addEntities)
            {
                entity.Id = Guid.NewGuid();
                entity.DateCrea = DateTime.UtcNow;
                entity.DateMaj = DateTime.UtcNow;
            }

            // Récupère les entités qui doivent être modifiées ou supprimées
            IEnumerable<BaseEntity> updEntities = ChangeTracker.Entries()
                                                           .Where(e => e.Entity is BaseEntity && (e.State == EntityState.Modified || e.State == EntityState.Deleted))
                                                           .Select(c => c.Entity as BaseEntity);

            foreach (BaseEntity entity in updEntities)
            {
                Entry(entity).Property(e => e.DateCrea).IsModified = false;
                entity.DateMaj = DateTime.UtcNow;
            }
        }


        /// <summary>
        /// Sauvegarde tous les changements effectués sur le contexte dans la BDD en gérant les propriétés DateCrea, DateMaj, UtiCrea, UtiMaj.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <param name="updateInformations"></param>
        /// <returns></returns>
        public virtual async Task<int> SaveBaseEntityChangesAsync(CancellationToken cancellationToken = default)
        {
            PopulateBaseInformations();
            return await SaveChangesAsync(cancellationToken)
                             .ConfigureAwait(false);
        }
    }
}
