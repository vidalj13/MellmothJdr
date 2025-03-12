using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MellmothJdr.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ArmesetArmure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("0441eff4-f2ca-4757-b02e-3e1043cf4234"),
                columns: new[] { "ArmeArmure", "ArmureStart", "ModificateurArmureStart" },
                values: new object[] { "Le Voleur sait manier les armes de contact à une main et toutes les armes à distance. Il peut seulement porter une armure de cuir simple et ne manie pas de bouclier.", "Armure de cuir", 2 });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("1a4b34b8-2752-4062-a0e5-59695a79d9c7"),
                columns: new[] { "ArmeArmure", "ArmureStart" },
                values: new object[] { "Le Magicien sait manier la dague et le bâton ferré et ne porte que des vêtements en tissu, donc aucune armure", "Armure de tissu" });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("2048962d-f0d3-460b-a054-fae5ea578cc3"),
                columns: new[] { "ArmeArmure", "ArmureStart" },
                values: new object[] { "L’Ensorceleur sait manier la dague et le bâton ferré. Il ne peut porter aucune armure (sauf si elle est faite de tissu) et ne peut pas manier le bouclier.", "Armure de tissu" });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("6e3fd8e2-1680-4a8b-b928-1e48acc20861"),
                columns: new[] { "ArmeArmure", "ArmureStart", "ModificateurArmureStart" },
                values: new object[] { "Le Rôdeur sait manier les armes de contact à une main et toutes les armes à distance, il peut porter toutes les armures à base de cuir mais ne manie pas de bouclier.", "Armure de cuir renforcée", 3 });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("7b00f70a-4e76-4d4c-8df5-c7ffe0022c20"),
                columns: new[] { "ArmeArmure", "ArmureStart" },
                values: new object[] { "Le Forgesort sait manier la dague, le bâton ferré, le marteau et l’arbalète légère. Il peut porter une armure de cuir simple seulement et ne peut pas manier de bouclier.", "Armure de tissu" });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("a91093ab-cdec-4d36-8e30-9393a955c382"),
                columns: new[] { "ArmeArmure", "ArmureStart", "ModificateurArmureStart" },
                values: new object[] { "Le Druide sait manier la dague, le gourdin, le bâton de Druide (équivalent à un bâton ferré), l’épieu, le javelot et l’arc court. Il peut porter l’armure de cuir et peut manier le petit bouclier en bois (DEF+1).", "Armure de cuir", 2 });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("b27608e8-b453-4397-8d41-7c3c3d9af293"),
                columns: new[] { "ArmeArmure", "ArmureStart", "ModificateurArmureStart" },
                values: new object[] { "Le Guerrier sait manier toutes les armes de contact et toutes les armes à distance. Il peut porter jusqu’à l’armure de demi-plaque et manier le bouclier.", "Armure de mailles", 5 });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("c67e5709-a257-4dcd-9250-6c2786327091"),
                columns: new[] { "ArmeArmure", "ArmureStart", "ModificateurArmureStart" },
                values: new object[] { "Le Chevalier sait manier toutes les armes de contact, mais il dédaigne les armes à distance qu’il considère comme des armes de couard. Il sait manier le bouclier et peut porter toutes les armures jusqu’à l’armure de plaques complète.", "Armure de demi-plaque", 6 });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("ded836b7-688e-4757-b100-1dc146142846"),
                columns: new[] { "ArmeArmure", "ArmureStart" },
                values: new object[] { "Le Nécromancien sait manier la dague et le bâton ferré. Il ne peut porter aucune armure (sauf si celle-ci est faite de tissu) et ne peut pas manier le bouclier.", "Armure de tissu" });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("e6d9a3ba-1dcc-4e33-859f-615dbbf3717f"),
                columns: new[] { "ArmeArmure", "ArmureStart" },
                values: new object[] { "Le Moine ne peut pas porter d’armure. Il sait manier toutes les armes, y compris celles à 2 mains, sauf les armes à poudre. Mais la plupart des Moines n’y font pas appel et sont plus efficaces à mains nues.", "Armure de tissu" });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("f5d228cd-75ee-4462-a2a7-102383250bdd"),
                columns: new[] { "ArmeArmure", "ArmureStart", "ModificateurArmureStart" },
                values: new object[] { "Le Prêtre sait manier les armes contondantes à une main (marteau, masse) plus une arme sacrée qui dépend de son dieu. Il peut porter jusqu'à une chemise de mailles et manier le petit ou le grand bouclier (au choix du MJ en fonction de la divinité).", "Chemise de maille", 4 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("0441eff4-f2ca-4757-b02e-3e1043cf4234"),
                columns: new[] { "ArmeArmure", "ArmureStart", "ModificateurArmureStart" },
                values: new object[] { null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("1a4b34b8-2752-4062-a0e5-59695a79d9c7"),
                columns: new[] { "ArmeArmure", "ArmureStart" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("2048962d-f0d3-460b-a054-fae5ea578cc3"),
                columns: new[] { "ArmeArmure", "ArmureStart" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("6e3fd8e2-1680-4a8b-b928-1e48acc20861"),
                columns: new[] { "ArmeArmure", "ArmureStart", "ModificateurArmureStart" },
                values: new object[] { null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("7b00f70a-4e76-4d4c-8df5-c7ffe0022c20"),
                columns: new[] { "ArmeArmure", "ArmureStart" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("a91093ab-cdec-4d36-8e30-9393a955c382"),
                columns: new[] { "ArmeArmure", "ArmureStart", "ModificateurArmureStart" },
                values: new object[] { null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("b27608e8-b453-4397-8d41-7c3c3d9af293"),
                columns: new[] { "ArmeArmure", "ArmureStart", "ModificateurArmureStart" },
                values: new object[] { null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("c67e5709-a257-4dcd-9250-6c2786327091"),
                columns: new[] { "ArmeArmure", "ArmureStart", "ModificateurArmureStart" },
                values: new object[] { null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("ded836b7-688e-4757-b100-1dc146142846"),
                columns: new[] { "ArmeArmure", "ArmureStart" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("e6d9a3ba-1dcc-4e33-859f-615dbbf3717f"),
                columns: new[] { "ArmeArmure", "ArmureStart" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("f5d228cd-75ee-4462-a2a7-102383250bdd"),
                columns: new[] { "ArmeArmure", "ArmureStart", "ModificateurArmureStart" },
                values: new object[] { null, null, 0 });
        }
    }
}
