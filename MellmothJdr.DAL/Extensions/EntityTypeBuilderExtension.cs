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
    }
}
