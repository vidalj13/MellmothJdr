using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MellmothJdr.DAL.Migrations
{
    /// <inheritdoc />
    public partial class RaceCODataV3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("  delete  from [Races] where Id not in('f47ac10b-58cc-4372-a567-0e02b2c3d479',\r\n'9c8d7e6f-5b4a-1234-cde9-0f1e2d3c4b5a',\r\n'a1b2c3d4-e5f6-47a8-90ab-cdef12345678',\r\n'01234567-89ab-cdef-0123-456789abcdef',\r\n'fedcba98-7654-3210-fedc-ba9876543210',\r\n'13579bdf-2468-ace0-bdf1-3579bdf24680',\r\n'11223344-5566-7788-99aa-bbccddeeff00',\r\n'abcdef12-3456-7890-abcd-ef1234567890');");
            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("01234567-89ab-cdef-0123-456789abcdef"),
                column: "Description",
                value: "Le Demi-elfe a hérité des qualités de ses deux parents (humain et Elfe). Il est généralement traité avec condescendance parmi les Elfes et est considéré comme un Elfe parmi les humains.\r\n\r\nLes Demi-elfes sont des artistes hors-pair dotés d'une grande sensibilité. Toutefois, attention car ils sont beaux parleurs et manipulateurs : cachez vos filles et vos femmes, ils ont brisé plus d'un cœur et corrompu bien des dames de réputation vertueuse.");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("13579bdf-2468-ace0-bdf1-3579bdf24680"),
                column: "Description",
                value: "Demi-orque\r\nLe Demi-orque est de grande taille. Issu de l’union souvent forcée d’une humaine et d’un Orque, il possède une force physique hors du commun. Il est généralement méprisé par les autres races, en particulier par les Nains et les Elfes.\r\n\r\nLes Demi-orques sont violents, sales et stupides, ils en veulent au monde entier de leur ignoble naissance et mieux vaut les éviter");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-e5f6-47a8-90ab-cdef12345678"),
                column: "Description",
                value: "Le Nain est petit mais robuste. Célèbre pour sa barbe, il aime les profondeurs de la terre, dont il extrait des métaux et des pierres précieuses. Isolé, il est généralement ouvert et chaleureux, mais la société naine peut paraître sévère car le travail et l’entraînement militaire y sont des obligations.\r\n\r\nLes Nains aiment amasser de l’or et boire de la bière en compagnie d’autres Nains. Ils sont un peu rustres et très susceptibles, un Nain peut se mettre en colère et devenir violent pour des raisons qui semblent étranges voire futiles à un autre peuple…");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                column: "Description",
                value: "L’humain se distingue par sa capacité d’adaptation et son instinct qui le pousse à coloniser tous les territoires qui l’entourent. La Race humaine est la plus représentée et la plus répandue dans les zones dites \"civilisées\".\r\n\r\nLes humains sont de jeunes loups ignorants, ils croissent et se multiplient sans aucun respect pour l’équilibre du monde, leur égoïsme et leur égocentrisme semblent sans limite. Ils mèneront le monde entier à la catastrophe si personne ne les arrête.");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("fedcba98-7654-3210-fedc-ba9876543210"),
                column: "Description",
                value: "Le Halfelin est la plus petite des races jouables. Toujours bon vivant, souvent vif, curieux, et parfois farceur, c’est un incompris que les autres Races considèrent souvent comme turbulent, pénible, voire parfois comme un voleur.\r\n\r\nLes Halfelins sont inoffensifs et ne pensent qu’à bien manger. Toutefois, ne perdez jamais de vue leurs mains car se sont aussi des voleurs sans scrupules.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("01234567-89ab-cdef-0123-456789abcdef"),
                column: "Description",
                value: "Issus de l'union entre humains et elfes, ils héritent d'atouts de ces deux univers, alliant souplesse et polyvalence.");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("13579bdf-2468-ace0-bdf1-3579bdf24680"),
                column: "Description",
                value: "Guerriers féroces, souvent en opposition avec les autres races, incarnant la force brute et l'esprit de combat.");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-e5f6-47a8-90ab-cdef12345678"),
                column: "Description",
                value: "Robustes et endurants, les nains sont réputés pour leur expertise en artisanat et en forge ainsi que pour leur courage au combat.");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                column: "Description",
                value: "La race la plus répandue, caractérisée par sa grande adaptabilité et sa diversité culturelle.");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: new Guid("fedcba98-7654-3210-fedc-ba9876543210"),
                column: "Description",
                value: "Petit peuple discret et ingénieux, reconnu pour sa capacité à se mouvoir sans être remarqué et à s'adapter à divers environnements.");
        }
    }
}
