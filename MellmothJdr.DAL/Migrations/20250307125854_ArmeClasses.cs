using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MellmothJdr.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ArmeClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ArmeArmure",
                table: "Classes",
                type: "varchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ArmureStart",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModificateurArmureStart",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ArmeStart",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Libelle = table.Column<string>(type: "varchar(200)", nullable: true),
                    PorteEnM = table.Column<int>(type: "int", nullable: true),
                    DeAttaque = table.Column<int>(type: "int", nullable: true),
                    NumbreDeAttaque = table.Column<int>(type: "int", nullable: true),
                    MinCritique = table.Column<int>(type: "int", nullable: true),
                    ClasseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCrea = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getutcdate()"),
                    DateMaj = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getutcdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmeStart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArmeStart_Classes_ClasseId",
                        column: x => x.ClasseId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ArmeStart",
                columns: new[] { "Id", "ClasseId", "DateCrea", "DateMaj", "DeAttaque", "Libelle", "MinCritique", "NumbreDeAttaque", "PorteEnM" },
                values: new object[,]
                {
                    { new Guid("626b4cbc-24fd-4cf4-b0b8-6ce09644a9e1"), new Guid("88a45295-7a95-487e-b881-fb9e0580a2a5"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Pétoire", null, 1, 20 },
                    { new Guid("739f46e1-8ef3-4f2a-926a-b5a04ad8d867"), new Guid("0b7fd2d0-c2ad-4492-ab38-f741174d5a6d"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "2 javelots", null, 1, 20 },
                    { new Guid("7b82ed7e-ba93-4373-939e-28ac1721c088"), new Guid("88a45295-7a95-487e-b881-fb9e0580a2a5"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Epée longue", null, 1, null },
                    { new Guid("9e473523-4c62-42c1-884b-e7f72048894a"), new Guid("91b825c3-3e5a-4e1b-8724-daf18ea27c6a"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Dague", null, 1, null },
                    { new Guid("bf7e1989-9173-4e2c-84c3-0a12f089c3e1"), new Guid("0b7fd2d0-c2ad-4492-ab38-f741174d5a6d"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Dague", null, 1, null },
                    { new Guid("c3ce1d4d-9a6f-4d5d-b2a6-dccf92afb9c2"), new Guid("91b825c3-3e5a-4e1b-8724-daf18ea27c6a"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Instrument de musique", null, null, null },
                    { new Guid("deedd7e0-f790-4ada-b987-d95b9c09d45b"), new Guid("91b825c3-3e5a-4e1b-8724-daf18ea27c6a"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Rapiere", 19, 1, null },
                    { new Guid("e71e64ca-b497-45dc-b4b3-40f89a28540e"), new Guid("88a45295-7a95-487e-b881-fb9e0580a2a5"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Dague", null, 1, null },
                    { new Guid("fd4b96f6-715a-43ab-9113-3cc1273aa66b"), new Guid("0b7fd2d0-c2ad-4492-ab38-f741174d5a6d"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Hache à 2 mains", null, 2, null }
                });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("0441eff4-f2ca-4757-b02e-3e1043cf4234"),
                columns: new[] { "ArmeArmure", "ArmureStart", "ModificateurArmureStart" },
                values: new object[] { null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("0b7fd2d0-c2ad-4492-ab38-f741174d5a6d"),
                columns: new[] { "ArmeArmure", "ArmureStart", "ModificateurArmureStart" },
                values: new object[] { "Le Barbare sait manier toutes les armes au contact, toutes les armes à distance (sauf les arbalètes et les armes d’une technologie trop complexe). Il peut porter jusqu’à l’armure de cuir et manier le bouclier.", "Armure de cuir", 2 });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("1a4b34b8-2752-4062-a0e5-59695a79d9c7"),
                columns: new[] { "ArmeArmure", "ArmureStart", "ModificateurArmureStart" },
                values: new object[] { null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("2048962d-f0d3-460b-a054-fae5ea578cc3"),
                columns: new[] { "ArmeArmure", "ArmureStart", "ModificateurArmureStart" },
                values: new object[] { null, null, 0 });

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
                columns: new[] { "ArmeArmure", "ArmureStart", "ModificateurArmureStart" },
                values: new object[] { null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("88a45295-7a95-487e-b881-fb9e0580a2a5"),
                columns: new[] { "ArmeArmure", "ArmureStart", "ModificateurArmureStart" },
                values: new object[] { "L’Arquebusier sait manier toutes les armes de contact à une main, les armes à distance et les armes à poudre. Il peut porter jusqu’à la chemise de maille et ne manie pas de bouclier.", "Armure de cuir", 2 });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("91b825c3-3e5a-4e1b-8724-daf18ea27c6a"),
                columns: new[] { "ArmeArmure", "ArmureStart", "ModificateurArmureStart" },
                values: new object[] { "Le Barde sait manier les armes à 1 main. Il peut porter jusqu’à l’armure de cuir renforcée et ne peut pas manier le bouclier.", "Armure de cuir", 2 });

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
                columns: new[] { "ArmeArmure", "ArmureStart", "ModificateurArmureStart" },
                values: new object[] { null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("e6d9a3ba-1dcc-4e33-859f-615dbbf3717f"),
                columns: new[] { "ArmeArmure", "ArmureStart", "ModificateurArmureStart" },
                values: new object[] { null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("f5d228cd-75ee-4462-a2a7-102383250bdd"),
                columns: new[] { "ArmeArmure", "ArmureStart", "ModificateurArmureStart" },
                values: new object[] { null, null, 0 });

            migrationBuilder.CreateIndex(
                name: "IX_ArmeStart_ClasseId",
                table: "ArmeStart",
                column: "ClasseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArmeStart");

            migrationBuilder.DropColumn(
                name: "ArmeArmure",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "ArmureStart",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "ModificateurArmureStart",
                table: "Classes");
        }
    }
}
