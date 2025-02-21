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
                    Description = "Le jeu de rôle Dungeons & Dragons consiste à narrer des aventures dans des mondes peuplés de guerriers et de magiciens. Tout comme les jeux où l'on s'amuse à faire semblant, D&D repose sur l'imagination.\r\n\r\nDans ce monde fantastique, les possibilités sont infinies.",
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                },
                new Jeu()
                {
                    Id = Ids.Jeux.ChroniquesOublies,
                    Nom = "Chroniques Oublies",
                    Description = "Chroniques Oubliées, conçue pour la découverte du JdR, est la version modernisée et simplifiée (mais pas simpliste) du premier des jeux de rôle. Aux mécaniques de base viennent s'ajouter des \"briques\" modulaires, optionnelles, pour enrichir l'expérience de jeu.\r\n\r\nSi vous souhaitiez découvrir (ou faire découvrir) le jeu de rôle ou si vous êtes à la recherche d'un jeu rapide à mettre en place pour renouer avec le loisir, ne cherchez pas plus loin !\r\n\r\nChroniques Oubliées se décline aujourd'hui dans sa version Fantasy (univers médiéval-fantastique), Contemporain (multiples univers possibles couvrant la période 1900-2100 : horreur lovecraftienne, pulp, zombies, vampires, super-héros, espionnage, policier, cyberpunk...) et Galactique (univers de science-fiction en trois époques : Space Opera, temps de la colonisation galactique et Hard Science).",
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                }
            });
        }
    }
    internal class PartieEntityConfiguration : IEntityTypeConfiguration<Partie>
    {
        public void Configure(EntityTypeBuilder<Partie> builder)
        {
            builder.ToTable("Parties");
            builder.ConfigureBaseEntity();

            builder.Property(x => x.Nom).HasColumnType("varchar(200)");
            builder.Property(x => x.NombreParticipant).IsRequired();
            builder.HasOne(x => x.User)
                .WithMany(x => x.Parties)
                .HasForeignKey(x => x.UserId);
            builder.HasOne(x => x.Jeu)
                .WithMany(x => x.Parties)
                .HasForeignKey(x => x.JeuId);
        }
    }
}
