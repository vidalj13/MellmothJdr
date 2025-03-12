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
                        Id = new Guid(""),
                        ClasseId = Ids.ChroniqueOublie.Classe.Ensorceleur,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeSoin = 8,
                        NumbreDeSoin = 1,
                    },
                    new()
                    {                    
                        Libelle = "Potion de soins",
                        Id = new Guid(""),
                        ClasseId = Ids.ChroniqueOublie.Classe.Magicien,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeSoin = 8,
                        NumbreDeSoin = 1,
                    },
                    new()
                    {                    
                        Libelle = "Potion de soins",
                        Id = new Guid(""),
                        ClasseId = Ids.ChroniqueOublie.Classe.Necromancien,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeSoin = 8,
                        NumbreDeSoin = 1,
                    },
            });
        }
    }
    internal class ArmeStartEntityConfiguration : IEntityTypeConfiguration<ArmeStart>
    {
        public void Configure(EntityTypeBuilder<ArmeStart> builder)
        {
            builder.ToTable("ArmeStart");
            builder.ConfigureBaseEntity();

            builder.Property(x => x.Libelle)
                .HasColumnType("varchar(200)");

            builder.HasOne(x => x.Classe)
                .WithMany(x => x.ArmesStarts)
                .HasForeignKey(x => x.ClasseId);

            DateTime dateInit = new(2025, 02, 25);
            builder.HasData(
                new List<ArmeStart>() {
                    new()
                    {
                        Libelle = "Pétoire",
                        Id = new Guid("626B4CBC-24FD-4CF4-B0B8-6CE09644A9E1"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Arquebusier,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 10,
                        PorteEnM = 20,
                        NumbreDeAttaque = 1
                    },
                    new()
                    {
                        Libelle = "Épée longue",
                        Id = new Guid("7B82ED7E-BA93-4373-939E-28AC1721C088"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Arquebusier,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 8,
                        NumbreDeAttaque = 1,
                        PorteEnM = null
                    },
                    new()
                    {
                        Libelle = "Dague",
                        Id = new Guid("E71E64CA-B497-45DC-B4B3-40F89A28540E"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Arquebusier,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 4,
                        NumbreDeAttaque = 1,
                        PorteEnM = null
                    },  
                    new()
                    {
                        Libelle = "Dague",
                        Id = new Guid("BF7E1989-9173-4E2C-84C3-0A12F089C3E1"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Barbare,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 4,
                        NumbreDeAttaque = 1,
                        PorteEnM = null
                    },   new()
                    {
                        Libelle = "Hache à 2 mains",
                        Id = new Guid("FD4B96F6-715A-43AB-9113-3CC1273AA66B"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Barbare,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 6,
                        NumbreDeAttaque = 2,
                        PorteEnM = null
                    },   new()
                    {
                        Libelle = "2 javelots",
                        Id = new Guid("739F46E1-8EF3-4F2A-926A-B5A04AD8D867"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Barbare,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 6,
                        NumbreDeAttaque = 1,
                        PorteEnM = 20
                    },
                    new()
                    {
                        Libelle = "Rapière",
                        Id = new Guid("DEEDD7E0-F790-4ADA-B987-D95B9C09D45B"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Barde,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 6,
                        NumbreDeAttaque = 1,
                        MinCritique = 19
                    },
                    new()
                    {
                        Libelle = "Dague",
                        Id = new Guid("9E473523-4C62-42C1-884B-E7F72048894A"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Barde,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 4,
                        NumbreDeAttaque = 1
                    },
                    new()
                    {
                        Libelle = "Instrument de musique",
                        Id = new Guid("C3CE1D4D-9A6F-4D5D-B2A6-DCCF92AFB9C2"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Barde,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },
                    new()
                    {
                        Libelle = "Épée longue",
                        Id = new Guid(""),
                        ClasseId = Ids.ChroniqueOublie.Classe.Chevalier,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 8,
                        NumbreDeAttaque = 1,
                        PorteEnM = null
                    },
                    new()
                    {
                        Libelle = "Grand bouclier",
                        Id = new Guid(""),
                        ClasseId = Ids.ChroniqueOublie.Classe.Chevalier,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        ModificateurDef = 2,
                    },
                    new()
                    {
                        Libelle = "Lance de cavalerie",
                        Id = new Guid(""),
                        ClasseId = Ids.ChroniqueOublie.Classe.Chevalier,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 6,
                        NumbreDeAttaque = 2
                    },
                    new()
                    {
                        Libelle = "Dague",
                        Id = new Guid(""),
                        ClasseId = Ids.ChroniqueOublie.Classe.Chevalier,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 4,
                        NumbreDeAttaque = 1
                    },
                    new()
                    {
                        Libelle = "Bâton",
                        Id = new Guid(""),
                        ClasseId = Ids.ChroniqueOublie.Classe.Druide,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 6,
                        NumbreDeAttaque = 1,
                    },
                    new()
                    {
                        Libelle = "Dague",
                        Id = new Guid(""),
                        ClasseId = Ids.ChroniqueOublie.Classe.Druide,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 4,
                        NumbreDeAttaque = 1,
                    },
                    new()
                    {
                        Libelle = "Arc court",
                        Id = new Guid(""),
                        ClasseId = Ids.ChroniqueOublie.Classe.Druide,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 6,
                        NumbreDeAttaque = 1,
                        PorteEnM = 30
                    },
                    new()
                    {
                        Libelle = "Bâton ferré",
                        Id = new Guid(""),
                        ClasseId = Ids.ChroniqueOublie.Classe.Ensorceleur,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 6 ,
                        NumbreDeAttaque = 1
                    },
                    new()
                    {
                        Libelle = "Dague",
                        Id = new Guid(""),
                        ClasseId = Ids.ChroniqueOublie.Classe.Ensorceleur,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 4,
                        NumbreDeAttaque = 1,
                    },
                    new()
                    {
                        Libelle = "Dague",
                        Id = new Guid(""),
                        ClasseId = Ids.ChroniqueOublie.Classe.Forgesort,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 4,
                        NumbreDeAttaque = 1,
                    },
                    new()
                    {
                        Libelle = "Bâton ferré",
                        Id = new Guid(""),
                        ClasseId = Ids.ChroniqueOublie.Classe.Forgesort,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 6 ,
                        NumbreDeAttaque = 1
                    },
                    new()
                    {
                        Libelle = "Marteau",
                        Id = new Guid(""),
                        ClasseId = Ids.ChroniqueOublie.Classe.Forgesort,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 6,
                        NumbreDeAttaque = 1
                    },
                    new()
                    {
                        Libelle = "Épée longue",
                        Id = new Guid(""),
                        ClasseId = Ids.ChroniqueOublie.Classe.Guerrier,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 8,
                        NumbreDeAttaque = 1
                    },
                    new()
                    {
                        Libelle = "Épée ou hache à 2 mains",
                        Id = new Guid(""),
                        ClasseId = Ids.ChroniqueOublie.Classe.Guerrier,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 6,
                        NumbreDeAttaque = 2                   
                    },
                    new()
                    {
                        Libelle = "Grand bouclier",
                        Id = new Guid(""),
                        ClasseId = Ids.ChroniqueOublie.Classe.Guerrier,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        ModificateurDef = 2,
                    },
                    new()
                    {
                        Libelle = "Bâton",
                        Id = new Guid(""),
                        ClasseId = Ids.ChroniqueOublie.Classe.Magicien,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 6,
                        NumbreDeAttaque = 1,
                    },
                    new()
                    {
                        Libelle = "Grimoire",
                        Id = new Guid(""),
                        ClasseId = Ids.ChroniqueOublie.Classe.Magicien,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                    },
                    new()
                    {
                        Libelle = "Dague",
                        Id = new Guid(""),
                        ClasseId = Ids.ChroniqueOublie.Classe.Magicien,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 4,
                        NumbreDeAttaque = 1,
                    },
                    new()
                    {
                        Libelle = "Bâton ferré",
                        Id = new Guid(""),
                        ClasseId = Ids.ChroniqueOublie.Classe.Moine,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 6 ,
                        NumbreDeAttaque = 1
                    },
                    new()
                    {
                        Libelle = "Dague",
                        Id = new Guid(""),
                        ClasseId = Ids.ChroniqueOublie.Classe.Nécromancien,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 4,
                        NumbreDeAttaque = 1,
                    },
                    new()
                    {
                        Libelle = "Bâton ferré",
                        Id = new Guid(""),
                        ClasseId = Ids.ChroniqueOublie.Classe.Nécromancien,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 6 ,
                        NumbreDeAttaque = 1
                    },
                    new()
                    {
                        Libelle = "Petit bouclier",
                        Id = new Guid(""),
                        ClasseId = Ids.ChroniqueOublie.Classe.Prêtre,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        ModificateurDef = 1,
                    },
                    new()
                    {
                        Libelle = "Marteau ou masse de guerre",
                        Id = new Guid(""),
                        ClasseId = Ids.ChroniqueOublie.Classe.Prêtre,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 6,
                        NumbreDeAttaque = 1
                    },
                    new()
                    {
                        Libelle = "Épée longue",
                        Id = new Guid(""),
                        ClasseId = Ids.ChroniqueOublie.Classe.Rôdeur,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 8,
                        NumbreDeAttaque = 1,
                    },
                    new()
                    {
                        Libelle = "Arc court",
                        Id = new Guid(""),
                        ClasseId = Ids.ChroniqueOublie.Classe.Rôdeur,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 6,
                        NumbreDeAttaque = 1,
                        PorteEnM = 30
                    },
                    new()
                    {
                        Libelle = "Dague",
                        Id = new Guid(""),
                        ClasseId = Ids.ChroniqueOublie.Classe.Rôdeur,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 4,
                        NumbreDeAttaque = 1,
                    },
                    new()
                    {
                        Libelle = "Carquois",
                        Id = new Guid(""),
                        ClasseId = Ids.ChroniqueOublie.Classe.Rôdeur,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                    },
                    new()
                    {
                        Libelle = "Dague de jet",
                        Id = new Guid(""),
                        ClasseId = Ids.ChroniqueOublie.Classe.Voleur,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        Quantite = 5
                        DeAttaque = 4,
                        NumbreDeAttaque = 1,
                    },
                    new()
                    {
                        Libelle = "Rapière",
                        Id = new Guid(""),
                        ClasseId = Ids.ChroniqueOublie.Classe.Voleur,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 6,
                        NumbreDeAttaque = 1,
                        MinCritique = 19
                    },
                    new()
                    {
                        Libelle = "Outils de crochetage",
                        Id = new Guid(""),
                        ClasseId = Ids.ChroniqueOublie.Classe.Voleur,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = ,
                        NumbreDeAttaque = ,
                        PorteEnM = 
                    },                });
        }
    }
}
