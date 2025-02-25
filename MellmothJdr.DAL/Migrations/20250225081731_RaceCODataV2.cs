using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MellmothJdr.DAL.Migrations
{
    /// <inheritdoc />
    public partial class RaceCODataV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("deadbeef-feed-face-cafe-babe12345678"));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("11223344-5566-7788-99aa-bbccddeeff00"),
                columns: new[] { "Description", "RaceLibelle" },
                values: new object[] { "L’Elfe sylvain est issu d’une culture différente de celle des Hauts-elfes. Légèrement plus petits, ils vivent au plus profond des forêts, s’abritant dans les arbres et vivant simplement de la chasse et de la cueillette. Moins arrogants que leurs cousins Hauts-elfes, ils sont cependant beaucoup plus méfiants. Ils maitrisent particulièrement l’art du camouflage et l’utilisation de l’arc.\r\n\r\nLes Elfes sylvains sont de redoutables archers, ils détestent les cités et les gens qui y vivent, ils peuvent tuer d’une flèche dans le dos un paysan juste parce qu'il a coupé le mauvais arbre.", "Elfe, sylvain" });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("13579bdf-2468-ace0-bdf1-3579bdf24680"),
                column: "RaceLibelle",
                value: "Demi-orques");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("9c8d7e6f-5b4a-1234-cde9-0f1e2d3c4b5a"),
                columns: new[] { "Description", "RaceLibelle" },
                values: new object[] { "Le Haut-elfe est un être féerique qui vit extrêmement longtemps. Il est méprisant envers les Nains et arrogant envers les autres races. Proche de la nature, il maîtrise aussi bien les arts de la magie que ceux de la guerre.\r\n\r\nLes Elfes se croient supérieurs à tous les autres, ce sont de puissants magiciens mais leur cœur est sans pitié. Ils obéissent à de très anciennes règles et à des serments incompréhensibles pour les Races à l’espérance de vie ordinaire.", "Elfe, haut" });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("abcdef12-3456-7890-abcd-ef1234567890"),
                columns: new[] { "Description", "RaceLibelle" },
                values: new object[] { "Le Gnome est une créature de petite taille pourvue d’un gros nez, d’une bonne nature et d’une curiosité insatiable pour la magie et les sciences. C’est un compagnon souvent agréable bien qu’un peu original. Les Nains et les Halfelins l’apprécient, tandis que les \"grandes\" races se montrent plutôt indifférentes à leur égard.\r\n\r\nLes Gnomes sont sympathiques mais à moitié fous, méfiez-vous comme de la peste de leurs inventions ou de leurs projets farfelus.", "Gnome" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("11223344-5566-7788-99aa-bbccddeeff00"),
                columns: new[] { "Description", "RaceLibelle" },
                values: new object[] { "Créatures rusées et agiles, généralement associées aux orques, mais possédant leur propre culture et méthodes de survie.", "Gobelins" });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("13579bdf-2468-ace0-bdf1-3579bdf24680"),
                column: "RaceLibelle",
                value: "Orques");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("9c8d7e6f-5b4a-1234-cde9-0f1e2d3c4b5a"),
                columns: new[] { "Description", "RaceLibelle" },
                values: new object[] { "Ces êtres longs-vivants, souvent subdivisés (par exemple en elfes sylvains ou des bois), se distinguent par leur élégance et leur lien étroit  avec la nature.", "Elfique(s)" });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("abcdef12-3456-7890-abcd-ef1234567890"),
                columns: new[] { "Description", "RaceLibelle" },
                values: new object[] { "Connus pour leur force exceptionnelle et leur capacité de régénération, ils représentent un défi de taille pour les aventuriers.", "Trolls" });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "DateCrea", "DateMaj", "Description", "JeuId", "RaceLibelle" },
                values: new object[] { new Guid("deadbeef-feed-face-cafe-babe12345678"), new DateTime(2025, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dotés de traits reptiliens et parfois liés à l'héritage des dragons, ces êtres apportent une dimension mystique et redoutable à l'univers.", new Guid("1c474c24-f5c9-470e-9b91-046b639275c3"), "Drakéides" });
        }
    }
}
