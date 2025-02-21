using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MellmothJdr.DAL.Migrations
{
    /// <inheritdoc />
    public partial class FichePersoChroniqueOubliePartie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PartieId",
                table: "FichesPersoChroniquesOublies",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FichesPersoChroniquesOublies_PartieId",
                table: "FichesPersoChroniquesOublies",
                column: "PartieId");

            migrationBuilder.AddForeignKey(
                name: "FK_FichesPersoChroniquesOublies_Parties_PartieId",
                table: "FichesPersoChroniquesOublies",
                column: "PartieId",
                principalTable: "Parties",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FichesPersoChroniquesOublies_Parties_PartieId",
                table: "FichesPersoChroniquesOublies");

            migrationBuilder.DropIndex(
                name: "IX_FichesPersoChroniquesOublies_PartieId",
                table: "FichesPersoChroniquesOublies");

            migrationBuilder.DropColumn(
                name: "PartieId",
                table: "FichesPersoChroniquesOublies");
        }
    }
}
