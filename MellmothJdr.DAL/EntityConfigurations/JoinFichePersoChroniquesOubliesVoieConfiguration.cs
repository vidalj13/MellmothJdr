using MellmothJdr.DAL.Entities.FichesPersos.ChroniquesOublies.Jointures;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Seedwork.EntityFramework.Extensions;

namespace NotificationManager.Infrastructure.EntityConfigurations
{
    internal class JoinFichePersoChroniquesOubliesVoieConfiguration : IEntityTypeConfiguration<JoinFichePersoChroniquesOubliesVoie>
    {
        public void Configure(EntityTypeBuilder<JoinFichePersoChroniquesOubliesVoie> builder)
        {
            builder.ToTable("JoinFichePersoChroniquesOubliesVoies");
            builder.ConfigureBaseEntity();

            builder.HasOne(x => x.Voie)
                .WithMany(x => x.JoinFichePersoChroniquesOubliesVoies)
                .HasForeignKey(x => x.VoieId);

            builder.HasOne(x => x.FichePersoChroniquesOublies)
                .WithMany(x => x.JoinFichePersoChroniquesOubliesVoies)
                .HasForeignKey(x => x.FichePersoChroniquesOubliesId);

        }
    }
}
