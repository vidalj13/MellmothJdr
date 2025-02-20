using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MellmothJdr.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitJeuxDesc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Jeux",
                keyColumn: "Id",
                keyValue: new Guid("0fc4e9f5-e8a8-4269-9dbc-2e5c4af3b2b1"),
                column: "Description",
                value: "Le jeu de rôle Dungeons & Dragons consiste à narrer des aventures dans des mondes peuplés de guerriers et de magiciens. Tout comme les jeux où l'on s'amuse à faire semblant, D&D repose sur l'imagination.\r\n\r\nDans ce monde fantastique, les possibilités sont infinies.");

            migrationBuilder.UpdateData(
                table: "Jeux",
                keyColumn: "Id",
                keyValue: new Guid("1c474c24-f5c9-470e-9b91-046b639275c3"),
                column: "Description",
                value: "Chroniques Oubliées, conçue pour la découverte du JdR, est la version modernisée et simplifiée (mais pas simpliste) du premier des jeux de rôle. Aux mécaniques de base viennent s'ajouter des \"briques\" modulaires, optionnelles, pour enrichir l'expérience de jeu.\r\n\r\nSi vous souhaitiez découvrir (ou faire découvrir) le jeu de rôle ou si vous êtes à la recherche d'un jeu rapide à mettre en place pour renouer avec le loisir, ne cherchez pas plus loin !\r\n\r\nChroniques Oubliées se décline aujourd'hui dans sa version Fantasy (univers médiéval-fantastique), Contemporain (multiples univers possibles couvrant la période 1900-2100 : horreur lovecraftienne, pulp, zombies, vampires, super-héros, espionnage, policier, cyberpunk...) et Galactique (univers de science-fiction en trois époques : Space Opera, temps de la colonisation galactique et Hard Science).");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Jeux",
                keyColumn: "Id",
                keyValue: new Guid("0fc4e9f5-e8a8-4269-9dbc-2e5c4af3b2b1"),
                column: "Description",
                value: "Donjons & Dragons");

            migrationBuilder.UpdateData(
                table: "Jeux",
                keyColumn: "Id",
                keyValue: new Guid("1c474c24-f5c9-470e-9b91-046b639275c3"),
                column: "Description",
                value: "Chroniques Oublies");
        }
    }
}
