using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MellmothJdr.DAL.Migrations
{
    /// <inheritdoc />
    public partial class VoieCo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VoieChroniquesOublies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Libelle = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(max)", nullable: true),
                    ClasseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCrea = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getutcdate()"),
                    DateMaj = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getutcdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoieChroniquesOublies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VoieChroniquesOublies_Classes_ClasseId",
                        column: x => x.ClasseId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JoinFichePersoChroniquesOubliesVoies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VoieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FichePersoChroniquesOubliesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCrea = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getutcdate()"),
                    DateMaj = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getutcdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JoinFichePersoChroniquesOubliesVoies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JoinFichePersoChroniquesOubliesVoies_FichesPersoChroniquesOublies_FichePersoChroniquesOubliesId",
                        column: x => x.FichePersoChroniquesOubliesId,
                        principalTable: "FichesPersoChroniquesOublies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JoinFichePersoChroniquesOubliesVoies_VoieChroniquesOublies_VoieId",
                        column: x => x.VoieId,
                        principalTable: "VoieChroniquesOublies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JoinFichePersoChroniquesOubliesVoies_FichePersoChroniquesOubliesId",
                table: "JoinFichePersoChroniquesOubliesVoies",
                column: "FichePersoChroniquesOubliesId");

            migrationBuilder.CreateIndex(
                name: "IX_JoinFichePersoChroniquesOubliesVoies_VoieId",
                table: "JoinFichePersoChroniquesOubliesVoies",
                column: "VoieId");

            migrationBuilder.CreateIndex(
                name: "IX_VoieChroniquesOublies_ClasseId",
                table: "VoieChroniquesOublies",
                column: "ClasseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JoinFichePersoChroniquesOubliesVoies");

            migrationBuilder.DropTable(
                name: "VoieChroniquesOublies");
        }
    }
}
