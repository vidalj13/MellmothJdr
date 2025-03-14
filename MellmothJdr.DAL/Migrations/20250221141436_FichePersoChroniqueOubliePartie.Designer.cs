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
    [Migration("20250221141436_FichePersoChroniqueOubliePartie")]
    partial class FichePersoChroniqueOubliePartie
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MellmothJdr.DAL.Entities.FichesPersos.FichePersoChroniquesOublies", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCrea")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<DateTime>("DateMaj")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<Guid?>("JeuId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Niveau")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("Varchar(250)");

                    b.Property<Guid?>("PartieId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("PoidKg")
                        .HasColumnType("int");

                    b.Property<int>("PvEnCours")
                        .HasColumnType("int");

                    b.Property<int>("PvMax")
                        .HasColumnType("int");

                    b.Property<Guid?>("RaceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RaceLibelle")
                        .IsRequired()
                        .HasColumnType("Varchar(250)");

                    b.Property<string>("Religion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TailleCm")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("JeuId");

                    b.HasIndex("PartieId");

                    b.HasIndex("RaceId");

                    b.ToTable("FichesPersoChroniquesOublies", (string)null);
                });

            modelBuilder.Entity("MellmothJdr.DAL.Entities.Jeu", b =>
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
                            Description = "Le jeu de rôle Dungeons & Dragons consiste à narrer des aventures dans des mondes peuplés de guerriers et de magiciens. Tout comme les jeux où l'on s'amuse à faire semblant, D&D repose sur l'imagination.\r\n\r\nDans ce monde fantastique, les possibilités sont infinies.",
                            Nom = "Donjons & Dragons"
                        },
                        new
                        {
                            Id = new Guid("1c474c24-f5c9-470e-9b91-046b639275c3"),
                            DateCrea = new DateTime(2025, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateMaj = new DateTime(2025, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Chroniques Oubliées, conçue pour la découverte du JdR, est la version modernisée et simplifiée (mais pas simpliste) du premier des jeux de rôle. Aux mécaniques de base viennent s'ajouter des \"briques\" modulaires, optionnelles, pour enrichir l'expérience de jeu.\r\n\r\nSi vous souhaitiez découvrir (ou faire découvrir) le jeu de rôle ou si vous êtes à la recherche d'un jeu rapide à mettre en place pour renouer avec le loisir, ne cherchez pas plus loin !\r\n\r\nChroniques Oubliées se décline aujourd'hui dans sa version Fantasy (univers médiéval-fantastique), Contemporain (multiples univers possibles couvrant la période 1900-2100 : horreur lovecraftienne, pulp, zombies, vampires, super-héros, espionnage, policier, cyberpunk...) et Galactique (univers de science-fiction en trois époques : Space Opera, temps de la colonisation galactique et Hard Science).",
                            Nom = "Chroniques Oublies"
                        });
                });

            modelBuilder.Entity("MellmothJdr.DAL.Entities.Partie", b =>
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

                    b.Property<Guid>("JeuId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nom")
                        .HasColumnType("varchar(200)");

                    b.Property<int?>("NombreParticipant")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("JeuId");

                    b.HasIndex("UserId");

                    b.ToTable("Parties", (string)null);
                });

            modelBuilder.Entity("MellmothJdr.DAL.Entities.Race", b =>
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

                    b.Property<Guid>("JeuId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RaceLibelle")
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("JeuId");

                    b.ToTable("Races", (string)null);
                });

            modelBuilder.Entity("MellmothJdr.DAL.Entities.User", b =>
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

            modelBuilder.Entity("MellmothJdr.DAL.Entities.FichesPersos.FichePersoChroniquesOublies", b =>
                {
                    b.HasOne("MellmothJdr.DAL.Entities.Jeu", "Jeu")
                        .WithMany("FichesPersoChroniquesOublies")
                        .HasForeignKey("JeuId");

                    b.HasOne("MellmothJdr.DAL.Entities.Partie", "Partie")
                        .WithMany("FichePersoChroniqueOublies")
                        .HasForeignKey("PartieId");

                    b.HasOne("MellmothJdr.DAL.Entities.Race", "Race")
                        .WithMany("FichesPersoChroniquesOublies")
                        .HasForeignKey("RaceId");

                    b.Navigation("Jeu");

                    b.Navigation("Partie");

                    b.Navigation("Race");
                });

            modelBuilder.Entity("MellmothJdr.DAL.Entities.Partie", b =>
                {
                    b.HasOne("MellmothJdr.DAL.Entities.Jeu", "Jeu")
                        .WithMany("Parties")
                        .HasForeignKey("JeuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MellmothJdr.DAL.Entities.User", "User")
                        .WithMany("Parties")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Jeu");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MellmothJdr.DAL.Entities.Race", b =>
                {
                    b.HasOne("MellmothJdr.DAL.Entities.Jeu", "Jeu")
                        .WithMany("Races")
                        .HasForeignKey("JeuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Jeu");
                });

            modelBuilder.Entity("MellmothJdr.DAL.Entities.Jeu", b =>
                {
                    b.Navigation("FichesPersoChroniquesOublies");

                    b.Navigation("Parties");

                    b.Navigation("Races");
                });

            modelBuilder.Entity("MellmothJdr.DAL.Entities.Partie", b =>
                {
                    b.Navigation("FichePersoChroniqueOublies");
                });

            modelBuilder.Entity("MellmothJdr.DAL.Entities.Race", b =>
                {
                    b.Navigation("FichesPersoChroniquesOublies");
                });

            modelBuilder.Entity("MellmothJdr.DAL.Entities.User", b =>
                {
                    b.Navigation("Parties");
                });
#pragma warning restore 612, 618
        }
    }
}
