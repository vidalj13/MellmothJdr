using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MellmothJdr.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitJeux : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jeux",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nom = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(max)", nullable: true),
                    DateCrea = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getutcdate()"),
                    DateMaj = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getutcdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jeux", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Jeux",
                columns: new[] { "Id", "DateCrea", "DateMaj", "Description", "Nom" },
                values: new object[,]
                {
                    { new Guid("0fc4e9f5-e8a8-4269-9dbc-2e5c4af3b2b1"), new DateTime(2025, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Donjons & Dragons", "Donjons & Dragons" },
                    { new Guid("1c474c24-f5c9-470e-9b91-046b639275c3"), new DateTime(2025, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chroniques Oublies", "Chroniques Oublies" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jeux");
        }
    }
}
