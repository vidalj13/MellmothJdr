using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MellmothJdr.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitProjet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateMaj",
                table: "Users",
                type: "datetime",
                nullable: false,
                defaultValueSql: "getutcdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCrea",
                table: "Users",
                type: "datetime",
                nullable: false,
                defaultValueSql: "getutcdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateMaj",
                table: "Users",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "getutcdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCrea",
                table: "Users",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "getutcdate()");
        }
    }
}
