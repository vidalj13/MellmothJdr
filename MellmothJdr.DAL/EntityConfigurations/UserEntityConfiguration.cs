using MellmothJdr.DAL.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Seedwork.EntityFramework.Extensions;

namespace NotificationManager.Infrastructure.EntityConfigurations
{
    internal class UserEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.ConfigureBaseEntity();
        }
    }
}
