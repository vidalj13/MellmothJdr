using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MellmothJdr.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UdateData3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("0441eff4-f2ca-4757-b02e-3e1043cf4234"),
                column: "Description",
                value: "\r\n                        Description =\"\",");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("0b7fd2d0-c2ad-4492-ab38-f741174d5a6d"),
                column: "Description",
                value: "Le Barbare est un combattant sauvage issu d’une culture primitive. Il affronte ses ennemis avec rage sans se cacher derrière une lourde armure.\r\n");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("1a4b34b8-2752-4062-a0e5-59695a79d9c7"),
                column: "Description",
                value: "Le Magicien n’est pas qu’un rat de bibliothèque. Il fait aussi appel à ses sorts pour se débarrasser de ses ennemis et pour aider ses compagnons.\r\n");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("2048962d-f0d3-460b-a054-fae5ea578cc3"),
                column: "Description",
                value: "L’Ensorceleur tire son pouvoir d’un talent inné pour la magie. Il pratique une magie subtile à base de tromperie et de contrôle, et possède peu de sorts de destruction massive.\r\n");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("6e3fd8e2-1680-4a8b-b928-1e48acc20861"),
                column: "Description",
                value: "Le Rôdeur est à l’aise dans les forêts ténébreuses, où il traque les animaux dangereux et les créatures monstrueuses ou, au contraire, se fait l’ami des bêtes et le protecteur des lieux sauvages.\r\n");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("7b00f70a-4e76-4d4c-8df5-c7ffe0022c20"),
                column: "Description",
                value: "À la fois artisan et enchanteur, artiste et magicien, le Forgesort lie les énergies occultes à la matière qu’il façonne pour créer des artefacts magiques ou des breuvages aux propriétés fantastiques.\r\n");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("91b825c3-3e5a-4e1b-8724-daf18ea27c6a"),
                column: "Description",
                value: "Le Barde est un personnage polyvalent qui utilise la magie et le spectacle pour divertir et parvenir à ses fins. Il est aussi habitué aux ruses qu’à la diplomatie.\r\n");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("a91093ab-cdec-4d36-8e30-9393a955c382"),
                column: "Description",
                value: "Le Druide est un prêtre de la nature qui défend sa pureté originelle et tire ses pouvoirs de la vie, des animaux et des plantes.\r\n");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("b27608e8-b453-4397-8d41-7c3c3d9af293"),
                column: "Description",
                value: "Le Guerrier est un combattant émérite qui n’a pas peur du danger et qui affronte ses ennemis l’arme à la main. De tous les profils de combattant, il est le plus spécialisé et le plus complet dans l’art du combat au corps à corps.\r\n");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("ded836b7-688e-4757-b100-1dc146142846"),
                column: "Description",
                value: "Le Nécromancien est un lanceur de sorts qui s’intéresse aux forces obscures et au pouvoir de la mort. Les Nécromanciens sont généralement considérés comme maléfiques et sont peu appréciés. Interprétez-le de façon subtile afin d’en faire un personnage plutôt sombre ou désespéré, mais pas forcément \"mauvais\" !\r\n");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("e6d9a3ba-1dcc-4e33-859f-615dbbf3717f"),
                column: "Description",
                value: "Le Moine combat à mains nues et utilise le contrôle qu’il a sur son esprit et son corps pour transformer ce dernier en arme de chair.\r\n");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("f5d228cd-75ee-4462-a2a7-102383250bdd"),
                column: "Description",
                value: "Le Prêtre utilise l’énergie transmise par son dieu pour mener à bien ses missions avec la force de la foi mais aussi celle des armes si nécessaire.\r\n");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("0441eff4-f2ca-4757-b02e-3e1043cf4234"),
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("0b7fd2d0-c2ad-4492-ab38-f741174d5a6d"),
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("1a4b34b8-2752-4062-a0e5-59695a79d9c7"),
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("2048962d-f0d3-460b-a054-fae5ea578cc3"),
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("6e3fd8e2-1680-4a8b-b928-1e48acc20861"),
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("7b00f70a-4e76-4d4c-8df5-c7ffe0022c20"),
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("91b825c3-3e5a-4e1b-8724-daf18ea27c6a"),
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("a91093ab-cdec-4d36-8e30-9393a955c382"),
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("b27608e8-b453-4397-8d41-7c3c3d9af293"),
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("ded836b7-688e-4757-b100-1dc146142846"),
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("e6d9a3ba-1dcc-4e33-859f-615dbbf3717f"),
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("f5d228cd-75ee-4462-a2a7-102383250bdd"),
                column: "Description",
                value: null);
        }
    }
}
