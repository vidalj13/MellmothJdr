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

            builder.Property(x => x.RaceLibelle).HasColumnType("varchar(200)");
            builder.HasOne(x => x.Jeu)
                .WithMany(x => x.Races)
                .HasForeignKey(x => x.JeuId);
        }
    }
}
