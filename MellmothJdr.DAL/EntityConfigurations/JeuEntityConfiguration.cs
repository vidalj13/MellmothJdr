using MellmothJdr.Commun.Constantes;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using NotificationManager.Infrastructure.Entities;

using Seedwork.EntityFramework.Extensions;

namespace NotificationManager.Infrastructure.EntityConfigurations
{
    internal class JeuEntityConfiguration : IEntityTypeConfiguration<Jeu>
    {
        public void Configure(EntityTypeBuilder<Jeu> builder)
        {
            builder.ToTable("Jeux");
            builder.ConfigureBaseEntity();

            builder.Property(x => x.Nom).HasColumnType("varchar(200)");
            builder.Property(x => x.Description).HasColumnType("varchar(max)");
            DateTime dateInit = new(2025, 02, 19);
            builder.HasData(new List<Jeu>()
            {
                new Jeu()
                {
                    Id = Ids.Jeux.DnD,
                    Nom = "Donjons & Dragons",
                    Description = "Donjons & Dragons",
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                },
                new Jeu()
                {
                    Id = Ids.Jeux.ChroniquesOublies,
                    Nom = "Chroniques Oublies",
                    Description = "Chroniques Oublies",
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                }
            });
        }
    }
}
