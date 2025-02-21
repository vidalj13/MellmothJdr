using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using NotificationManager.Infrastructure.Entities;

using Seedwork.EntityFramework.Extensions;

namespace NotificationManager.Infrastructure.EntityConfigurations
{
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
