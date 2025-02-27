using MellmothJdr.Commun.Constantes;
using MellmothJdr.DAL.Entities.FichesPersos.ChroniquesOublies;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Seedwork.EntityFramework.Extensions;

namespace NotificationManager.Infrastructure.EntityConfigurations
{
    internal class VoieChroniquesOubliesEntityConfiguration : IEntityTypeConfiguration<VoieChroniquesOublies>
    {
        DateTime dateInit = new(2025, 02, 25);
        public void Configure(EntityTypeBuilder<VoieChroniquesOublies> builder)
        {
            builder.ToTable("VoieChroniquesOublies");
            builder.ConfigureBaseEntity();

            builder.Property(x => x.Libelle)
                .HasColumnType("varchar(200)");
            builder.Property(x => x.Description)
                .HasColumnType("varchar(max)");
            builder.HasOne(x => x.Classe)
                .WithMany(x => x.VoieChroniquesOublies)
                .HasForeignKey(x => x.ClasseId);


            List<VoieChroniquesOublies> data = new List<VoieChroniquesOublies>();
            PopulateChevalier(data);
            builder.HasData(
                data);
        }

        private void PopulateChevalier(List<VoieChroniquesOublies> data)
        {
            data.AddRange(new List<VoieChroniquesOublies>()
            {
                new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Chevalier,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Description = "Voie de la guerre",
                    Libelle = "Voie de la guerre",
                    Id  = Ids.ChroniqueOublie.Voie.Guerre,
                },
                new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Chevalier,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Description = "Voie du héro",
                    Libelle = "Voie du héro",
                    Id  = Ids.ChroniqueOublie.Voie.Hero,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Chevalier,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Description = "Voie du meneur d'home",
                    Libelle = "Voie du meneur d'home",
                    Id  = Ids.ChroniqueOublie.Voie.Meneur,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Chevalier,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Description = "Voie du Cavalier",
                    Libelle = "Voie du Cavalier",
                    Id  = Ids.ChroniqueOublie.Voie.Cavalier,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Chevalier,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Description = "Voie de la noblesse",
                    Libelle = "Voie de la noblesse",
                    Id  = Ids.ChroniqueOublie.Voie.Noblesse
                },
            });
        }
    }
}
