using MellmothJdr.Commun.Constantes;
using MellmothJdr.DAL.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Seedwork.EntityFramework.Extensions;

namespace NotificationManager.Infrastructure.EntityConfigurations
{
    internal class SoinStartEntityConfiguration : IEntityTypeConfiguration<SoinStart>
    {
        public void Configure(EntityTypeBuilder<SoinStart> builder)
        {
            builder.ToTable("SoinStart");
            builder.ConfigureBaseEntity();

            builder.Property(x => x.Libelle)
                .HasColumnType("varchar(200)");

            builder.HasOne(x => x.Classe)
                .WithMany(x => x.SoinsStarts)
                .HasForeignKey(x => x.ClasseId);

            DateTime dateInit = new(2025, 02, 25);

            builder.HasData(new List<SoinStart>() {
                    new()
                    {
                        Libelle = "Potion de soins",
                        Id = new Guid("EFA42275-F8A6-4C3B-ABA0-EC97C6DE1A23"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Ensorceleur,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeSoin = 8,
                        NombreDeSoin = 1,
                    },
                    new()
                    {
                        Libelle = "Potion de soins",
                        Id = new Guid("9ADD0625-5C5F-461A-A2D7-72381AE57E07"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Magicien,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeSoin = 8,
                        NombreDeSoin = 1,
                    },
                    new()
                    {
                        Libelle = "Potion de soins",
                        Id = new Guid("29224826-839B-4766-8326-34DEDFCB59CE"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Necromancien,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeSoin = 8,
                        NombreDeSoin = 1,
                    },
            });
        }
    }
}
