using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MellmothJdr.DAL.Migrations
{
    /// <inheritdoc />
    public partial class StuffStart3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("739f46e1-8ef3-4f2a-926a-b5a04ad8d867"),
                columns: new[] { "Libelle", "Quantite" },
                values: new object[] { "Javelots", 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("739f46e1-8ef3-4f2a-926a-b5a04ad8d867"),
                columns: new[] { "Libelle", "Quantite" },
                values: new object[] { "2 javelots", null });
        }
    }
}
