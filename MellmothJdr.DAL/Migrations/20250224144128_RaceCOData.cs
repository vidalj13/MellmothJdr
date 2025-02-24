using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MellmothJdr.DAL.Migrations
{
    /// <inheritdoc />
    public partial class RaceCOData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Races",
                type: "varchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "DateCrea", "DateMaj", "Description", "JeuId", "RaceLibelle" },
                values: new object[,]
                {
                    { new Guid("01234567-89ab-cdef-0123-456789abcdef"), new DateTime(2025, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Issus de l'union entre humains et elfes, ils héritent d'atouts de ces deux univers, alliant souplesse et polyvalence.", new Guid("1c474c24-f5c9-470e-9b91-046b639275c3"), "Demi-Elfes" },
                    { new Guid("11223344-5566-7788-99aa-bbccddeeff00"), new DateTime(2025, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Créatures rusées et agiles, généralement associées aux orques, mais possédant leur propre culture et méthodes de survie.", new Guid("1c474c24-f5c9-470e-9b91-046b639275c3"), "Gobelins" },
                    { new Guid("13579bdf-2468-ace0-bdf1-3579bdf24680"), new DateTime(2025, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guerriers féroces, souvent en opposition avec les autres races, incarnant la force brute et l'esprit de combat.", new Guid("1c474c24-f5c9-470e-9b91-046b639275c3"), "Orques" },
                    { new Guid("9c8d7e6f-5b4a-1234-cde9-0f1e2d3c4b5a"), new DateTime(2025, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ces êtres longs-vivants, souvent subdivisés (par exemple en elfes sylvains ou des bois), se distinguent par leur élégance et leur lien étroit  avec la nature.", new Guid("1c474c24-f5c9-470e-9b91-046b639275c3"), "Elfique(s)" },
                    { new Guid("a1b2c3d4-e5f6-47a8-90ab-cdef12345678"), new DateTime(2025, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robustes et endurants, les nains sont réputés pour leur expertise en artisanat et en forge ainsi que pour leur courage au combat.", new Guid("1c474c24-f5c9-470e-9b91-046b639275c3"), "Nains" },
                    { new Guid("abcdef12-3456-7890-abcd-ef1234567890"), new DateTime(2025, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Connus pour leur force exceptionnelle et leur capacité de régénération, ils représentent un défi de taille pour les aventuriers.", new Guid("1c474c24-f5c9-470e-9b91-046b639275c3"), "Trolls" },
                    { new Guid("deadbeef-feed-face-cafe-babe12345678"), new DateTime(2025, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dotés de traits reptiliens et parfois liés à l'héritage des dragons, ces êtres apportent une dimension mystique et redoutable à l'univers.", new Guid("1c474c24-f5c9-470e-9b91-046b639275c3"), "Drakéides" },
                    { new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"), new DateTime(2025, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "La race la plus répandue, caractérisée par sa grande adaptabilité et sa diversité culturelle.", new Guid("1c474c24-f5c9-470e-9b91-046b639275c3"), "Humains" },
                    { new Guid("fedcba98-7654-3210-fedc-ba9876543210"), new DateTime(2025, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petit peuple discret et ingénieux, reconnu pour sa capacité à se mouvoir sans être remarqué et à s'adapter à divers environnements.", new Guid("1c474c24-f5c9-470e-9b91-046b639275c3"), "Halfelins" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("01234567-89ab-cdef-0123-456789abcdef"));

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("11223344-5566-7788-99aa-bbccddeeff00"));

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("13579bdf-2468-ace0-bdf1-3579bdf24680"));

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("9c8d7e6f-5b4a-1234-cde9-0f1e2d3c4b5a"));

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-e5f6-47a8-90ab-cdef12345678"));

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("abcdef12-3456-7890-abcd-ef1234567890"));

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("deadbeef-feed-face-cafe-babe12345678"));

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"));

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("fedcba98-7654-3210-fedc-ba9876543210"));

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Races");
        }
    }
}
