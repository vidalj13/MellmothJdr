using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MellmothJdr.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Classes2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FichesPersoChroniquesOublies_Classes_ClasseId",
                table: "FichesPersoChroniquesOublies");

            migrationBuilder.DropIndex(
                name: "IX_FichesPersoChroniquesOublies_ClasseId",
                table: "FichesPersoChroniquesOublies");

            migrationBuilder.DropColumn(
                name: "ClasseId",
                table: "FichesPersoChroniquesOublies");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ClasseId",
                table: "FichesPersoChroniquesOublies",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FichesPersoChroniquesOublies_ClasseId",
                table: "FichesPersoChroniquesOublies",
                column: "ClasseId");

            migrationBuilder.AddForeignKey(
                name: "FK_FichesPersoChroniquesOublies_Classes_ClasseId",
                table: "FichesPersoChroniquesOublies",
                column: "ClasseId",
                principalTable: "Classes",
                principalColumn: "Id");
        }
    }
}
