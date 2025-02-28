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
            builder.HasOne(x => x.Classe)
                .WithMany(x => x.VoieChroniquesOublies)
                .HasForeignKey(x => x.ClasseId);


            List<VoieChroniquesOublies> data = new List<VoieChroniquesOublies>();
            PopulateArquebusier(data);
            PopulateBarbare(data);
            PopulateBarde(data);
            PopulateChevalier(data);
            PopulateDruide(data);
            PopulateEnsorceleur(data);
            builder.HasData(
                data);
        }

        private void PopulateArquebusier(List<VoieChroniquesOublies> data)
        {
            data.AddRange(new List<VoieChroniquesOublies>()
            {
                new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Arquebusier,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie de l'artilleur",
                    Id  = Ids.ChroniqueOublie.Voie.Artilleur,
                },
                new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Arquebusier,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie des explosifs",
                    Id  = Ids.ChroniqueOublie.Voie.Explosifs,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Arquebusier,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie du champs de bataille",
                    Id  = Ids.ChroniqueOublie.Voie.ChampsDeBataille,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Arquebusier,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie du pistolero",
                    Id  = Ids.ChroniqueOublie.Voie.Pistolero,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Arquebusier,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie de la Précision",
                    Id  = Ids.ChroniqueOublie.Voie.Precision
                },
            });
        }

        private void PopulateBarbare(List<VoieChroniquesOublies> data)
        {
            data.AddRange(new List<VoieChroniquesOublies>()
            {
                new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Barbare,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie de la brute",
                    Id  = Ids.ChroniqueOublie.Voie.Brute,
                },
                new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Barbare,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie du pagnes",
                    Id  = Ids.ChroniqueOublie.Voie.Pagnes,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Barbare,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie du pourfendeur",
                    Id  = Ids.ChroniqueOublie.Voie.Pourfendeur,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Barbare,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie du primitif",
                    Id  = Ids.ChroniqueOublie.Voie.Primitif,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Barbare,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie de la rage",
                    Id  = Ids.ChroniqueOublie.Voie.Rage
                },
            });
        }

        private void PopulateBarde(List<VoieChroniquesOublies> data)
        {
            data.AddRange(new List<VoieChroniquesOublies>()
            {
                new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Barde,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie de l'escrime",
                    Id  = Ids.ChroniqueOublie.Voie.Escrime,
                },
                new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Barde,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie du musicien",
                    Id  = Ids.ChroniqueOublie.Voie.Musicien,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Barde,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie du saltimbanque",
                    Id  = Ids.ChroniqueOublie.Voie.Saltimbanque,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Barde,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie de la séduction",
                    Id  = Ids.ChroniqueOublie.Voie.Seduction,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Barde,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie du vagabond",
                    Id  = Ids.ChroniqueOublie.Voie.Vagabond
                },
            });
        }

        private void PopulateDruide(List<VoieChroniquesOublies> data)
        {
            data.AddRange(new List<VoieChroniquesOublies>()
            {
                new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Druide,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie des animaux",
                    Id  = Ids.ChroniqueOublie.Voie.Animaux,
                },
                new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Druide,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie du fauve",
                    Id  = Ids.ChroniqueOublie.Voie.Fauve,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Druide,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie de la nature",
                    Id  = Ids.ChroniqueOublie.Voie.Nature,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Druide,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie du protecteur",
                    Id  = Ids.ChroniqueOublie.Voie.Protecteur,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Druide,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie des végétaux",
                    Id  = Ids.ChroniqueOublie.Voie.Vegetaux
                },
            });
        }

        private void PopulateEnsorceleur(List<VoieChroniquesOublies> data)
        {
            data.AddRange(new List<VoieChroniquesOublies>()
            {
                new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Ensorceleur,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie de l'air",
                    Id  = Ids.ChroniqueOublie.Voie.Air,
                },
                new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Ensorceleur,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie de la divination",
                    Id  = Ids.ChroniqueOublie.Voie.Divination,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Ensorceleur,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie de l'envoûteur",
                    Id  = Ids.ChroniqueOublie.Voie.Envouteur,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Ensorceleur,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie des illusions",
                    Id  = Ids.ChroniqueOublie.Voie.Illusions,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Ensorceleur,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie de l'invocation",
                    Id  = Ids.ChroniqueOublie.Voie.Invocationx
                },
            });
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
                    Libelle = "Voie de la guerre",
                    Id  = Ids.ChroniqueOublie.Voie.Guerre,
                },
                new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Chevalier,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie du héro",
                    Id  = Ids.ChroniqueOublie.Voie.Hero,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Chevalier,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie du meneur d'home",
                    Id  = Ids.ChroniqueOublie.Voie.Meneur,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Chevalier,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie du Cavalier",
                    Id  = Ids.ChroniqueOublie.Voie.Cavalier,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Chevalier,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie de la noblesse",
                    Id  = Ids.ChroniqueOublie.Voie.Noblesse
                },
            });
        }
    }
}






































