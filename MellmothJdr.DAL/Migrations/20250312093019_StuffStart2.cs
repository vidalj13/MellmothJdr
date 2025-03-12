using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MellmothJdr.DAL.Migrations
{
    /// <inheritdoc />
    public partial class StuffStart2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("cd0de432-6a9d-4eb3-b2b4-62834f8684fa"),
                column: "PorteEnM",
                value: 5);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("cd0de432-6a9d-4eb3-b2b4-62834f8684fa"),
                column: "PorteEnM",
                value: null);
        }
    }
}
