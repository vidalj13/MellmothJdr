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
            PopulateWar(data);
            PopulateForgesort(data);
            PopulateMagicien(data);
            PopulatePretre(data);
            PopulateMoine(data);
            PopulateRodeur(data);
            PopulateVoleur(data);
            PopulateNecromancien(data);
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

        private void PopulateForgesort(List<VoieChroniquesOublies> data)
        {
            data.AddRange(new List<VoieChroniquesOublies>()
            {
                new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Forgesort,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie des artefacts",
                    Id  = Ids.ChroniqueOublie.Voie.Artefacts,
                },
                new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Forgesort,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie des élixirs",
                    Id  = Ids.ChroniqueOublie.Voie.Elixirs,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Forgesort,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie du métal",
                    Id  = Ids.ChroniqueOublie.Voie.Metal,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Forgesort,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie du golem",
                    Id  = Ids.ChroniqueOublie.Voie.Golem,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Forgesort,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie des runes",
                    Id  = Ids.ChroniqueOublie.Voie.Runes
                },
            });
        }

        private void PopulateWar(List<VoieChroniquesOublies> data)
        {
            data.AddRange(new List<VoieChroniquesOublies>()
            {
                new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Guerrier,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie du bouclier",
                    Id  = Ids.ChroniqueOublie.Voie.Bouclier,
                },
                new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Guerrier,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie du combat",
                    Id  = Ids.ChroniqueOublie.Voie.Combat,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Guerrier,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie du maître d'armes",
                    Id  = Ids.ChroniqueOublie.Voie.armes,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Guerrier,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie de la résistance",
                    Id  = Ids.ChroniqueOublie.Voie.Resistance,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Guerrier,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie du soldat",
                    Id  = Ids.ChroniqueOublie.Voie.Soldats
                },
            });
        }

        private void PopulateMagicien(List<VoieChroniquesOublies> data)
        {
            data.AddRange(new List<VoieChroniquesOublies>()
            {
                new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Magicien,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie de la magie des arcanes",
                    Id  = Ids.ChroniqueOublie.Voie.Magiearcanes,
                },
                new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Magicien,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie de la magie destructrice",
                    Id  = Ids.ChroniqueOublie.Voie.Magiedestructrice,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Magicien,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie de la magie élémentaire",
                    Id  = Ids.ChroniqueOublie.Voie.Magieélémentaire,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Magicien,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie de la magie protectrice",
                    Id  = Ids.ChroniqueOublie.Voie.Magieprotectrice,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Magicien,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie de la magie universelle",
                    Id  = Ids.ChroniqueOublie.Voie.Magieuniverselle
                },
            });
        }

        private void PopulateMoine(List<VoieChroniquesOublies> data)
        {
            data.AddRange(new List<VoieChroniquesOublies>()
            {
                new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Moine,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie de l’énergie vitale",
                    Id  = Ids.ChroniqueOublie.Voie.MoineVitale,
                },
                new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Moine,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie de la maîtrise",
                    Id  = Ids.ChroniqueOublie.Voie.MoineMaitrise,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Moine,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie de la méditation",
                    Id  = Ids.ChroniqueOublie.Voie.MoineMeditation,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Moine,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie du poing",
                    Id  = Ids.ChroniqueOublie.Voie.MoinePoing,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Moine,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie du vent",
                    Id  = Ids.ChroniqueOublie.Voie.MoineVent
                },
            });
        }

        private void PopulateNecromancien(List<VoieChroniquesOublies> data)
        {
            data.AddRange(new List<VoieChroniquesOublies>()
            {
                new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Necromancien,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie du démon",
                    Id  = Ids.ChroniqueOublie.Voie.NecromancienDemon,
                },
                new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Necromancien,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie de la mort",
                    Id  = Ids.ChroniqueOublie.Voie.NecromancienMort,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Necromancien,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie de l’outre-tombe",
                    Id  = Ids.ChroniqueOublie.Voie.NecromancienTombe,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Necromancien,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie du sang",
                    Id  = Ids.ChroniqueOublie.Voie.NecromancienSang,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Necromancien,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie de la sombre magie",
                    Id  = Ids.ChroniqueOublie.Voie.NecromancienMagie
                },
            });
        }

        private void PopulatePretre(List<VoieChroniquesOublies> data)
        {
            data.AddRange(new List<VoieChroniquesOublies>()
            {
                new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Pretre,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie de la foi",
                    Id  = Ids.ChroniqueOublie.Voie.PretreFoi,
                },
                new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Pretre,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie de la guerre",
                    Id  = Ids.ChroniqueOublie.Voie.PretreGuerre,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Pretre,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie de la prière",
                    Id  = Ids.ChroniqueOublie.Voie.PretrePriere,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Pretre,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie des soins",
                    Id  = Ids.ChroniqueOublie.Voie.PretreSoins,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Pretre,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie de la spiritualité",
                    Id  = Ids.ChroniqueOublie.Voie.PretreSpiritualite
                },
            });
        }

        private void PopulateRodeur(List<VoieChroniquesOublies> data)
        {
            data.AddRange(new List<VoieChroniquesOublies>()
            {
                new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Rodeur,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie de l’archer",
                    Id  = Ids.ChroniqueOublie.Voie.RodeurArcher ,
                },
                new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Rodeur,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie du compagnon animal",
                    Id  = Ids.ChroniqueOublie.Voie.RodeurCompagnonAnimal ,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Rodeur,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie de l’escarmouche",
                    Id  = Ids.ChroniqueOublie.Voie.RodeurEscarmouche ,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Rodeur,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie de la survie",
                    Id  = Ids.ChroniqueOublie.Voie.RodeurSurvie ,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Rodeur,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie du traqueur",
                    Id  = Ids.ChroniqueOublie.Voie.RodeurTraqueur 
                },    new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Rodeur,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie du montreur d’ours",
                    Id  = Ids.ChroniqueOublie.Voie.RodeurMontreurOurs 
                },
            });
        }

        private void PopulateVoleur(List<VoieChroniquesOublies> data)
        {
            data.AddRange(new List<VoieChroniquesOublies>()
            {
                new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Voleur,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie de l’assassin",
                    Id  = Ids.ChroniqueOublie.Voie.VoleurAssassin,
                },
                new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Voleur,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie de l’aventurier",
                    Id  = Ids.ChroniqueOublie.Voie.VoleurAventurier,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Voleur,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie du déplacement",
                    Id  = Ids.ChroniqueOublie.Voie.VoleurDeplacement,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Voleur,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie du roublard",
                    Id  = Ids.ChroniqueOublie.Voie.VoleurRoublard,
                },      new()
                {
                    ClasseId =  Ids.ChroniqueOublie.Classe.Voleur,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Voie du spadassin",
                    Id  = Ids.ChroniqueOublie.Voie.VoleurSpadassin
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