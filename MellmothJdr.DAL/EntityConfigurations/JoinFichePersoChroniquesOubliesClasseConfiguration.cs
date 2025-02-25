using MellmothJdr.DAL.Entities.Jointures;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Seedwork.EntityFramework.Extensions;

namespace NotificationManager.Infrastructure.EntityConfigurations
{
    internal class JoinFichePersoChroniquesOubliesClasseConfiguration : IEntityTypeConfiguration<JoinFichePersoChroniquesOubliesClasse>
    {
        public void Configure(EntityTypeBuilder<JoinFichePersoChroniquesOubliesClasse> builder)
        {
            builder.ToTable("JoinFichePersoChroniquesOubliesClasses");
            builder.ConfigureBaseEntity();

            builder.HasOne(x => x.Classe)
                .WithMany(x => x.JoinFichePersoChroniquesOubliesClasses)
                .HasForeignKey(x => x.ClasseId);

            builder.HasOne(x => x.FichePersoChroniquesOublies)
                .WithMany(x => x.JoinFichePersoChroniquesOubliesClasses)
                .HasForeignKey(x => x.FichePersoChroniquesOubliesId);
        }
    }
}
