﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TransverseApiSessionCDR.Infrastructure;

#nullable disable

namespace MellmothJdr.DAL.Migrations
{
    [DbContext(typeof(MigrationContext))]
    [Migration("20250219140139_InitJeux")]
    partial class InitJeux
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NotificationManager.Infrastructure.Entities.Jeu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCrea")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<DateTime>("DateMaj")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Nom")
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Jeux", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("0fc4e9f5-e8a8-4269-9dbc-2e5c4af3b2b1"),
                            DateCrea = new DateTime(2025, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateMaj = new DateTime(2025, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Donjons & Dragons",
                            Nom = "Donjons & Dragons"
                        },
                        new
                        {
                            Id = new Guid("1c474c24-f5c9-470e-9b91-046b639275c3"),
                            DateCrea = new DateTime(2025, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateMaj = new DateTime(2025, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Chroniques Oublies",
                            Nom = "Chroniques Oublies"
                        });
                });

            modelBuilder.Entity("NotificationManager.Infrastructure.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCrea")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<DateTime>("DateMaj")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<string>("ExterneId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
