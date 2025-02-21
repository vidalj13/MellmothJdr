using MellmothJdr.DAL.Entities;
using MellmothJdr.DAL.Entities.FichesPersos;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Seedwork.EntityFramework.Extensions;

namespace NotificationManager.Infrastructure.EntityConfigurations
{
    internal class RaceEntityConfiguration : IEntityTypeConfiguration<Race>
    {
        public void Configure(EntityTypeBuilder<Race> builder)
        {
            builder.ToTable("Races");
            builder.ConfigureBaseEntity();

            builder.Property(x => x.RaceLibelle).HasColumnType("varchar(200)");
            builder.HasOne(x => x.Jeu)
                .WithMany(x => x.Races)
                .HasForeignKey(x => x.JeuId);
        }
    }
    
    internal class FichePersoChroniquesOubliesConfiguration : IEntityTypeConfiguration<FichePersoChroniquesOublies>
    {
        public void Configure(EntityTypeBuilder<FichePersoChroniquesOublies> builder)
        {
            builder.ToTable("FichesPersoChroniquesOublies");

            System.Linq.Expressions.Expression<Func<Race, IEnumerable<FichePersoChroniquesOublies>>> navigationExpressionRaces = x => x.FichesPersoChroniquesOublies;
            System.Linq.Expressions.Expression<Func<Jeu, IEnumerable<FichePersoChroniquesOublies>>> navigationExpressionJeux = x => x.FichesPersoChroniquesOublies;
            builder.ConfigureBaseFichePersoEntity(navigationExpressionRaces, navigationExpressionJeux);

        }
    }
}
