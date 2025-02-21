using MellmothJdr.DAL.Entities.FichesPersos;
using MellmothJdr.DAL.Entities;
using System.Linq.Expressions;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using NotificationManager.Infrastructure.Entities.Base;

namespace Seedwork.EntityFramework.Extensions
{
    public static class EntityTypeBuilderExtension
    {
        /// <summary>
        /// Configure les champs de base des entités héritant du type <seealso cref="BaseEntity"/>
        /// </summary>
        /// <typeparam name="T">classe de type <seealso cref="BaseEntity"/></typeparam>
        /// <param name="builder"></param>
        public static void ConfigureBaseEntity<T>(this EntityTypeBuilder<T> builder) where T : BaseEntity
        {
            builder.HasKey(x => x.Id);
            builder.Property(e => e.Id).IsRequired();

            builder.Property(e => e.DateCrea)
                .HasColumnType("datetime")
                .HasDefaultValueSql("getutcdate()")
                .IsRequired();

            builder.Property(e => e.DateMaj)
                .HasColumnType("datetime")
                .HasDefaultValueSql("getutcdate()");
        }


        /// <summary>
        /// Configure les champs de base des entités héritant du type <seealso cref="BaseFichePersoEntity"/>
        /// </summary>
        /// <typeparam name="T">classe de type <seealso cref="BaseEntity"/></typeparam>
        /// <param name="builder"></param>
        public static void ConfigureBaseFichePersoEntity<T>(this EntityTypeBuilder<T> builder, 
            Expression<Func<Race, IEnumerable<T>>> navigationExpressionRaces, 
            Expression<Func<Jeu, IEnumerable<T>>> navigationExpressionJeux) where T : BaseFichePersoEntity
        {
            builder.ConfigureBaseEntity();

            builder.Property(e => e.Nom)
                .HasColumnType("Varchar(250)")
                .IsRequired();

            builder.Property(e => e.RaceLibelle)
                .HasColumnType("Varchar(250)")
                .IsRequired();
            builder.Property(e => e.TailleCm)
                .IsRequired();
            builder.Property(e => e.PoidKg)
                .IsRequired();
            builder.Property(e => e.Age)
                .IsRequired();
            builder.Property(e => e.Niveau)
                .IsRequired();
            builder.Property(e => e.PvMax)
                .IsRequired();
            builder.Property(e => e.PvEnCours)
                .IsRequired();

            builder.HasOne(x => x.Race)
                .WithMany(navigationExpressionRaces)
                .HasForeignKey(x => x.RaceId);
            builder.HasOne(x => x.Jeu)
                .WithMany(navigationExpressionJeux)
                .HasForeignKey(x => x.JeuId);
        }
    }
}
