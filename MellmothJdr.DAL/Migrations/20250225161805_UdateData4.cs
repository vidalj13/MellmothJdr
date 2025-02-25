using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MellmothJdr.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UdateData4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("0441eff4-f2ca-4757-b02e-3e1043cf4234"),
                column: "Description",
                value: "Le Voleur crochète les portes, détecte les pièges et préfère piller les cadavres des ennemis que de se salir les mains pendant le combat.\r\n");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("0441eff4-f2ca-4757-b02e-3e1043cf4234"),
                column: "Description",
                value: "\r\n                        Description =\"\",");
        }
    }
}
