using MellmothJdr.Commun.Constantes;
using MellmothJdr.DAL.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Seedwork.EntityFramework.Extensions;

namespace NotificationManager.Infrastructure.EntityConfigurations
{
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
            builder.HasOne(x => x.Jeu)
                .WithMany(x => x.Classes)
                .HasForeignKey(x => x.JeuId);

            DateTime dateInit = new(2025, 02, 25);
            builder.HasData(
                new List<Classe>() {

                    new()
                    {
                        Libelle = "Arquebusier",
                        Id = Ids.Classe.Arquebusier,
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },

                    new()
                    {
                        Libelle = "Barbare",
                        Id = Ids.Classe.Barbare,
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },

                    new()
                    {
                        Libelle = "Barde",
                        Id = Ids.Classe.Barde,
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },

                    new()
                    {
                        Libelle = "Chevalier",
                        Id = Ids.Classe.Chevalier,
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },

                    new()
                    {
                        Libelle = "Druide",
                        Id = Ids.Classe.Druide,
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },

                    new()
                    {
                        Libelle = "Ensorceleur",
                        Id = Ids.Classe.Ensorceleur,
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },

                    new()
                    {
                        Libelle = "Forgesort",
                        Id = Ids.Classe.Forgesort,
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },

                    new()
                    {
                        Libelle = "Guerrier",
                        Id = Ids.Classe.Guerrier,
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },

                    new()
                    {
                        Libelle = "Magicien",
                        Id = Ids.Classe.Magicien,
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },

                    new()
                    {
                        Libelle = "Moine",
                        Id = Ids.Classe.Moine,
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },

                    new()
                    {
                        Libelle = "Nécromancien",
                        Id = Ids.Classe.Necromancien,
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },

                    new()
                    {
                        Libelle = "Prêtre",
                        Id = Ids.Classe.Pretre,
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },

                    new()
                    {
                        Libelle = "Rôdeur",
                        Id = Ids.Classe.Rodeur,
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },

                    new()
                    {
                        Libelle = "Voleur",
                        Id = Ids.Classe.Voleur,
                        JeuId = Ids.Jeux.ChroniquesOublies,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },

            });
        }
    }
}
