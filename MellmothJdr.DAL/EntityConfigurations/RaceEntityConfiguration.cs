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
                        Description = "La race la plus répandue, caractérisée par sa grande adaptabilité et sa diversité culturelle.",
                        Id = Ids.Race.Humains,
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },
                    new()
                    {
                        RaceLibelle = "Elfique(s)",
                        Description = "Ces êtres longs-vivants, souvent subdivisés (par exemple en elfes sylvains ou des bois), se distinguent par leur élégance et leur lien étroit  avec la nature.",
                        Id = Ids.Race.Elfique,
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },
                    new ()
                    {
                        RaceLibelle = "Nains",
                        Description = "Robustes et endurants, les nains sont réputés pour leur expertise en artisanat et en forge ainsi que pour leur courage au combat.",
                        Id = Ids.Race.Nains,
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },
                    new ()
                    {
                        RaceLibelle = "Demi-Elfes",
                        Description = "Issus de l'union entre humains et elfes, ils héritent d'atouts de ces deux univers, alliant souplesse et polyvalence.",
                        Id = Ids.Race.DemiElfes,
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },
                    new ()
                    {
                        RaceLibelle = "Halfelins",
                        Description = "Petit peuple discret et ingénieux, reconnu pour sa capacité à se mouvoir sans être remarqué et à s'adapter à divers environnements.",
                        Id = Ids.Race.Halfelins,
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },
                    new ()
                    {
                        RaceLibelle = "Orques",
                        Description = "Guerriers féroces, souvent en opposition avec les autres races, incarnant la force brute et l'esprit de combat.",
                        Id = Ids.Race.Orques,
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },
                    new ()
                    {
                        RaceLibelle = "Gobelins",
                        Description = "Créatures rusées et agiles, généralement associées aux orques, mais possédant leur propre culture et méthodes de survie.",
                        Id = Ids.Race.Gobelins,
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },
                    new ()
                    {
                        RaceLibelle = "Trolls",
                        Description = "Connus pour leur force exceptionnelle et leur capacité de régénération, ils représentent un défi de taille pour les aventuriers.",
                        Id = Ids.Race.Trolls,
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },
                    new ()
                    {
                        RaceLibelle = "Drakéides",
                        Description = "Dotés de traits reptiliens et parfois liés à l'héritage des dragons, ces êtres apportent une dimension mystique et redoutable à l'univers.",
                        Id = Ids.Race.Drakeides,
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },
            });
        }
    }
}
