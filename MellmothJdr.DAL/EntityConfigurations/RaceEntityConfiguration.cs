using MellmothJdr.Commun.Constantes;
using MellmothJdr.DAL.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Seedwork.EntityFramework.Extensions;

namespace NotificationManager.Infrastructure.EntityConfigurations
{
    internal class RaceEntityConfiguration : IEntityTypeConfiguration<Race>
    {
        public void Configure(EntityTypeBuilder<Race> builder)
        {
            builder.ToTable("Races");
            builder.ConfigureBaseEntity();

            builder.Property(x => x.RaceLibelle)
                .HasColumnType("varchar(200)");
            builder.Property(x => x.Description)
                .HasColumnType("varchar(max)");
            builder.HasOne(x => x.Jeu)
                .WithMany(x => x.Races)
                .HasForeignKey(x => x.JeuId);

            DateTime dateInit = new(2025, 02, 24);
            builder.HasData(
                new List<Race>() {
                    new ()
                    {
                        RaceLibelle = "Humains",
                        Description = "L’humain se distingue par sa capacité d’adaptation et son instinct qui le pousse à coloniser tous les territoires qui l’entourent. La Race humaine est la plus représentée et la plus répandue dans les zones dites \"civilisées\".\r\n\r\nLes humains sont de jeunes loups ignorants, ils croissent et se multiplient sans aucun respect pour l’équilibre du monde, leur égoïsme et leur égocentrisme semblent sans limite. Ils mèneront le monde entier à la catastrophe si personne ne les arrête.",
                        Id = Ids.Race.Humains,
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },
                    new()
                    {
                        RaceLibelle = "Elfe, haut",
                        Description = "Le Haut-elfe est un être féerique qui vit extrêmement longtemps. Il est méprisant envers les Nains et arrogant envers les autres races. Proche de la nature, il maîtrise aussi bien les arts de la magie que ceux de la guerre.\r\n\r\nLes Elfes se croient supérieurs à tous les autres, ce sont de puissants magiciens mais leur cœur est sans pitié. Ils obéissent à de très anciennes règles et à des serments incompréhensibles pour les Races à l’espérance de vie ordinaire.",
                        Id = Ids.Race.ElfeHaut,
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },
                    new ()
                    {
                        RaceLibelle = "Nains",
                        Description = "Le Nain est petit mais robuste. Célèbre pour sa barbe, il aime les profondeurs de la terre, dont il extrait des métaux et des pierres précieuses. Isolé, il est généralement ouvert et chaleureux, mais la société naine peut paraître sévère car le travail et l’entraînement militaire y sont des obligations.\r\n\r\nLes Nains aiment amasser de l’or et boire de la bière en compagnie d’autres Nains. Ils sont un peu rustres et très susceptibles, un Nain peut se mettre en colère et devenir violent pour des raisons qui semblent étranges voire futiles à un autre peuple…",
                        Id = Ids.Race.Nains,
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },
                    new ()
                    {
                        RaceLibelle = "Demi-Elfes",
                        Description = "Le Demi-elfe a hérité des qualités de ses deux parents (humain et Elfe). Il est généralement traité avec condescendance parmi les Elfes et est considéré comme un Elfe parmi les humains.\r\n\r\nLes Demi-elfes sont des artistes hors-pair dotés d'une grande sensibilité. Toutefois, attention car ils sont beaux parleurs et manipulateurs : cachez vos filles et vos femmes, ils ont brisé plus d'un cœur et corrompu bien des dames de réputation vertueuse.",
                        Id = Ids.Race.DemiElfes,
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },
                    new ()
                    {
                        RaceLibelle = "Halfelins",
                        Description = "Le Halfelin est la plus petite des races jouables. Toujours bon vivant, souvent vif, curieux, et parfois farceur, c’est un incompris que les autres Races considèrent souvent comme turbulent, pénible, voire parfois comme un voleur.\r\n\r\nLes Halfelins sont inoffensifs et ne pensent qu’à bien manger. Toutefois, ne perdez jamais de vue leurs mains car se sont aussi des voleurs sans scrupules.",
                        Id = Ids.Race.Halfelins,
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },
                    new ()
                    {
                        RaceLibelle = "Demi-orques",
                        Description = "Demi-orque\r\nLe Demi-orque est de grande taille. Issu de l’union souvent forcée d’une humaine et d’un Orque, il possède une force physique hors du commun. Il est généralement méprisé par les autres races, en particulier par les Nains et les Elfes.\r\n\r\nLes Demi-orques sont violents, sales et stupides, ils en veulent au monde entier de leur ignoble naissance et mieux vaut les éviter",
                        Id = Ids.Race.DemiOrques,
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },
                    new ()
                    {
                        RaceLibelle = "Elfe, sylvain",
                        Description = "L’Elfe sylvain est issu d’une culture différente de celle des Hauts-elfes. Légèrement plus petits, ils vivent au plus profond des forêts, s’abritant dans les arbres et vivant simplement de la chasse et de la cueillette. Moins arrogants que leurs cousins Hauts-elfes, ils sont cependant beaucoup plus méfiants. Ils maitrisent particulièrement l’art du camouflage et l’utilisation de l’arc.\r\n\r\nLes Elfes sylvains sont de redoutables archers, ils détestent les cités et les gens qui y vivent, ils peuvent tuer d’une flèche dans le dos un paysan juste parce qu'il a coupé le mauvais arbre.",
                        Id = Ids.Race.ElfeSylvain,
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },
                    new ()
                    {
                        RaceLibelle = "Gnome",
                        Description = "Le Gnome est une créature de petite taille pourvue d’un gros nez, d’une bonne nature et d’une curiosité insatiable pour la magie et les sciences. C’est un compagnon souvent agréable bien qu’un peu original. Les Nains et les Halfelins l’apprécient, tandis que les \"grandes\" races se montrent plutôt indifférentes à leur égard.\r\n\r\nLes Gnomes sont sympathiques mais à moitié fous, méfiez-vous comme de la peste de leurs inventions ou de leurs projets farfelus.",
                        Id = Ids.Race.Gnome,
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    }
            });
        }
    }
}
