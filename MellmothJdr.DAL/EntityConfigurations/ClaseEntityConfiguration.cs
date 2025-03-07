﻿using MellmothJdr.Commun.Constantes;
using MellmothJdr.DAL.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Seedwork.EntityFramework.Extensions;

namespace NotificationManager.Infrastructure.EntityConfigurations
{

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
                        Id = new Guid("626B4CBC-24FD-4CF4-B0B8-6CE09644A9E1\r\n"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Arquebusier,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 10,
                        PorteEnM = 20,
                        NumbreDeAttaque = 1
                    },
                    new()
                    {
                        Libelle = "Epée longue",
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
                        Libelle = "Rapiere",
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
                });
        }
    }
    internal class ClaseEntityConfiguration : IEntityTypeConfiguration<Classe>
    {
        public void Configure(EntityTypeBuilder<Classe> builder)
        {
            builder.ToTable("Classes");
            builder.ConfigureBaseEntity();

            builder.Property(x => x.Libelle)
                .HasColumnType("varchar(200)");
            builder.Property(x => x.Description)
                .HasColumnType("varchar(max)");
            builder.Property(x => x.ArmeArmure)
                .HasColumnType("varchar(max)");
            builder.HasOne(x => x.Jeu)
                .WithMany(x => x.Classes)
                .HasForeignKey(x => x.JeuId);

            DateTime dateInit = new(2025, 02, 25);
            builder.HasData(
                new List<Classe>() {
                    new()
                    {
                        Libelle = "Arquebusier",
                        Id = Ids.ChroniqueOublie.Classe.Arquebusier,
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        Description = "L’Arquebusier est un dur à cuire, un soldat ou un mercenaire habitué des champs de bataille. C’est un spécialiste du combat à distance et plus particulièrement des armes à feu et des explosifs.",
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        ArmeArmure = "L’Arquebusier sait manier toutes les armes de contact à une main, les armes à distance et les armes à poudre. Il peut porter jusqu’à la chemise de maille et ne manie pas de bouclier.",
                        ArmureStart = "Armure de cuir",
                        ModificateurArmureStart = 2,
                    },

                    new()
                    {
                        Libelle = "Barbare",
                        Id = Ids.ChroniqueOublie.Classe.Barbare,
                        Description ="Le Barbare est un combattant sauvage issu d’une culture primitive. Il affronte ses ennemis avec rage sans se cacher derrière une lourde armure.\r\n",
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        ArmeArmure = "Le Barbare sait manier toutes les armes au contact, toutes les armes à distance (sauf les arbalètes et les armes d’une technologie trop complexe). Il peut porter jusqu’à l’armure de cuir et manier le bouclier.",
                        ArmureStart = "Armure de cuir",
                        ModificateurArmureStart = 2,       
                    },

                    new()
                    {
                        Libelle = "Barde",
                        Id = Ids.ChroniqueOublie.Classe.Barde,
                        Description ="Le Barde est un personnage polyvalent qui utilise la magie et le spectacle pour divertir et parvenir à ses fins. Il est aussi habitué aux ruses qu’à la diplomatie.\r\n",
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        ArmeArmure = "Le Barde sait manier les armes à 1 main. Il peut porter jusqu’à l’armure de cuir renforcée et ne peut pas manier le bouclier.",
                        ArmureStart = "Armure de cuir",
                        ModificateurArmureStart = 2,       
                    },

                    new()
                    {
                        Libelle = "Chevalier",
                        Id = Ids.ChroniqueOublie.Classe.Chevalier,
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        Description = "Le Chevalier est un noble guerrier errant, monté sur un puissant destrier et protégé par une armure lourde. Il parcourt la campagne en quête de torts à redresser et d’occasions de mettre son courage à l’épreuve.",
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },

                    new()
                    {
                        Libelle = "Druide",
                        Id = Ids.ChroniqueOublie.Classe.Druide,
                        Description ="Le Druide est un prêtre de la nature qui défend sa pureté originelle et tire ses pouvoirs de la vie, des animaux et des plantes.\r\n",
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },

                    new()
                    {
                        Libelle = "Ensorceleur",
                        Id = Ids.ChroniqueOublie.Classe.Ensorceleur,
                        Description ="L’Ensorceleur tire son pouvoir d’un talent inné pour la magie. Il pratique une magie subtile à base de tromperie et de contrôle, et possède peu de sorts de destruction massive.\r\n",
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },

                    new()
                    {
                        Libelle = "Forgesort",
                        Id = Ids.ChroniqueOublie.Classe.Forgesort,
                        Description ="À la fois artisan et enchanteur, artiste et magicien, le Forgesort lie les énergies occultes à la matière qu’il façonne pour créer des artefacts magiques ou des breuvages aux propriétés fantastiques.\r\n",
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },

                    new()
                    {
                        Libelle = "Guerrier",
                        Id = Ids.ChroniqueOublie.Classe.Guerrier,
                        Description ="Le Guerrier est un combattant émérite qui n’a pas peur du danger et qui affronte ses ennemis l’arme à la main. De tous les profils de combattant, il est le plus spécialisé et le plus complet dans l’art du combat au corps à corps.\r\n",
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },

                    new()
                    {
                        Libelle = "Magicien",
                        Id = Ids.ChroniqueOublie.Classe.Magicien,
                        Description ="Le Magicien n’est pas qu’un rat de bibliothèque. Il fait aussi appel à ses sorts pour se débarrasser de ses ennemis et pour aider ses compagnons.\r\n",
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },

                    new()
                    {
                        Libelle = "Moine",
                        Id = Ids.ChroniqueOublie.Classe.Moine,
                        Description ="Le Moine combat à mains nues et utilise le contrôle qu’il a sur son esprit et son corps pour transformer ce dernier en arme de chair.\r\n",
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },

                    new()
                    {
                        Libelle = "Nécromancien",
                        Id = Ids.ChroniqueOublie.Classe.Necromancien,
                        Description ="Le Nécromancien est un lanceur de sorts qui s’intéresse aux forces obscures et au pouvoir de la mort. Les Nécromanciens sont généralement considérés comme maléfiques et sont peu appréciés. Interprétez-le de façon subtile afin d’en faire un personnage plutôt sombre ou désespéré, mais pas forcément \"mauvais\" !\r\n",
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },

                    new()
                    {
                        Libelle = "Prêtre",
                        Id = Ids.ChroniqueOublie.Classe.Pretre,
                        Description ="Le Prêtre utilise l’énergie transmise par son dieu pour mener à bien ses missions avec la force de la foi mais aussi celle des armes si nécessaire.\r\n",
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },

                    new()
                    {
                        Libelle = "Rôdeur",
                        Id = Ids.ChroniqueOublie.Classe.Rodeur,
                        Description ="Le Rôdeur est à l’aise dans les forêts ténébreuses, où il traque les animaux dangereux et les créatures monstrueuses ou, au contraire, se fait l’ami des bêtes et le protecteur des lieux sauvages.\r\n",
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },

                    new()
                    {
                        Libelle = "Voleur",
                        Id = Ids.ChroniqueOublie.Classe.Voleur,
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        Description ="Le Voleur crochète les portes, détecte les pièges et préfère piller les cadavres des ennemis que de se salir les mains pendant le combat.\r\n",
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },

            });
        }
    }
}
