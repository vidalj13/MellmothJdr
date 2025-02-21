using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MellmothJdr.DAL.Migrations
{
    /// <inheritdoc />
    public partial class FichePersoChroniqueOublie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RaceLibelle = table.Column<string>(type: "varchar(200)", nullable: true),
                    JeuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCrea = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getutcdate()"),
                    DateMaj = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getutcdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Races_Jeux_JeuId",
                        column: x => x.JeuId,
                        principalTable: "Jeux",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FichesPersoChroniquesOublies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCrea = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getutcdate()"),
                    DateMaj = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getutcdate()"),
                    Nom = table.Column<string>(type: "Varchar(250)", nullable: false),
                    RaceLibelle = table.Column<string>(type: "Varchar(250)", nullable: false),
                    TailleCm = table.Column<int>(type: "int", nullable: false),
                    PoidKg = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Religion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Niveau = table.Column<int>(type: "int", nullable: false),
                    PvMax = table.Column<int>(type: "int", nullable: false),
                    PvEnCours = table.Column<int>(type: "int", nullable: false),
                    RaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    JeuId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FichesPersoChroniquesOublies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FichesPersoChroniquesOublies_Jeux_JeuId",
                        column: x => x.JeuId,
                        principalTable: "Jeux",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FichesPersoChroniquesOublies_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_FichesPersoChroniquesOublies_JeuId",
                table: "FichesPersoChroniquesOublies",
                column: "JeuId");

            migrationBuilder.CreateIndex(
                name: "IX_FichesPersoChroniquesOublies_RaceId",
                table: "FichesPersoChroniquesOublies",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_JeuId",
                table: "Races",
                column: "JeuId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FichesPersoChroniquesOublies");

            migrationBuilder.DropTable(
                name: "Races");
        }
    }
}
