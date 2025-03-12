using MellmothJdr.Commun.Constantes;
using MellmothJdr.DAL.Entities.FichesPersos.ChroniquesOublies;
using MellmothJdr.DAL.Entities.FichesPersos.ChroniquesOublies.Jointures;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Seedwork.EntityFramework.Extensions;

namespace NotificationManager.Infrastructure.EntityConfigurations
{
    internal class TalentChroniquesOubliesConfiguration : IEntityTypeConfiguration<TalentChroniquesOublies>
    {
        DateTime dateInit = new(2025, 03, 12);
        public void Configure(EntityTypeBuilder<TalentChroniquesOublies> builder)
        {
            builder.ToTable("TalentChroniquesOublies");
            builder.ConfigureBaseEntity();

            builder.HasOne(x => x.Voie)
                .WithMany(x => x.TalentsChroniquesOubliesVoies)
                .HasForeignKey(x => x.VoieId);

            List<TalentChroniquesOublies> data = new List<TalentChroniquesOublies>();
            //PopulateArquebusier(data);
            //PopulateBarbare(data);
            //PopulateBarde(data);
            //PopulateChevalier(data);
            //PopulateDruide(data);
            //PopulateEnsorceleur(data);
            //PopulateWar(data);
            //PopulateForgesort(data);
            //PopulateMagicien(data);
            //PopulatePretre(data);
            //PopulateMoine(data);
            //PopulateRodeur(data);
            //PopulateVoleur(data);
            //PopulateNecromancien(data);
            builder.HasData(
                data);

        }
        /*
            new()
                {
                    VoieId =  Ids.ChroniqueOublie.Voie.Artilleur,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "",
                    Description = "",
                    Rang = ,
                    Id  = new Guid(""),
                },
        */
        private void PopulateArquebusier(List<TalentChroniquesOublies> data)
        {
            data.AddRange(new List<TalentChroniquesOublies>()
            {
                new()
                {
                    VoieId =  Ids.ChroniqueOublie.Voie.Artilleur,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "",
                    Id  = new Guid(""),
                },
            });
        }
    }
}
