using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MellmothJdr.DAL.Migrations
{
    /// <inheritdoc />
    public partial class FichePersoChroniqueOublieUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "FichesPersoChroniquesOublies",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_FichesPersoChroniquesOublies_UserId",
                table: "FichesPersoChroniquesOublies",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_FichesPersoChroniquesOublies_Users_UserId",
                table: "FichesPersoChroniquesOublies",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FichesPersoChroniquesOublies_Users_UserId",
                table: "FichesPersoChroniquesOublies");

            migrationBuilder.DropIndex(
                name: "IX_FichesPersoChroniquesOublies_UserId",
                table: "FichesPersoChroniquesOublies");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "FichesPersoChroniquesOublies");
        }
    }
}
