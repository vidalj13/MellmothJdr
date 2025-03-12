using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MellmothJdr.DAL.Migrations
{
    /// <inheritdoc />
    public partial class StuffStart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NumbreDeSoin",
                table: "SoinStart",
                newName: "NombreDeSoin");

            migrationBuilder.RenameColumn(
                name: "NumbreDeAttaque",
                table: "ArmeStart",
                newName: "Quantite");

            migrationBuilder.AddColumn<int>(
                name: "ModificateurDef",
                table: "ArmeStart",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NombreDeAttaque",
                table: "ArmeStart",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("626b4cbc-24fd-4cf4-b0b8-6ce09644a9e1"),
                columns: new[] { "ModificateurDef", "NombreDeAttaque", "Quantite" },
                values: new object[] { null, 1, null });

            migrationBuilder.UpdateData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("739f46e1-8ef3-4f2a-926a-b5a04ad8d867"),
                columns: new[] { "ModificateurDef", "NombreDeAttaque", "Quantite" },
                values: new object[] { null, 1, null });

            migrationBuilder.UpdateData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("7b82ed7e-ba93-4373-939e-28ac1721c088"),
                columns: new[] { "Libelle", "ModificateurDef", "NombreDeAttaque", "Quantite" },
                values: new object[] { "Épée longue", null, 1, null });

            migrationBuilder.UpdateData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("9e473523-4c62-42c1-884b-e7f72048894a"),
                columns: new[] { "ModificateurDef", "NombreDeAttaque", "Quantite" },
                values: new object[] { null, 1, null });

            migrationBuilder.UpdateData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("bf7e1989-9173-4e2c-84c3-0a12f089c3e1"),
                columns: new[] { "ModificateurDef", "NombreDeAttaque", "Quantite" },
                values: new object[] { null, 1, null });

            migrationBuilder.UpdateData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("c3ce1d4d-9a6f-4d5d-b2a6-dccf92afb9c2"),
                columns: new[] { "ModificateurDef", "NombreDeAttaque" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("deedd7e0-f790-4ada-b987-d95b9c09d45b"),
                columns: new[] { "Libelle", "ModificateurDef", "NombreDeAttaque", "Quantite" },
                values: new object[] { "Rapière", null, 1, null });

            migrationBuilder.UpdateData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("e71e64ca-b497-45dc-b4b3-40f89a28540e"),
                columns: new[] { "ModificateurDef", "NombreDeAttaque", "Quantite" },
                values: new object[] { null, 1, null });

            migrationBuilder.UpdateData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("fd4b96f6-715a-43ab-9113-3cc1273aa66b"),
                columns: new[] { "ModificateurDef", "NombreDeAttaque", "Quantite" },
                values: new object[] { null, 2, null });

            migrationBuilder.InsertData(
                table: "ArmeStart",
                columns: new[] { "Id", "ClasseId", "DateCrea", "DateMaj", "DeAttaque", "Libelle", "MinCritique", "ModificateurDef", "NombreDeAttaque", "PorteEnM", "Quantite" },
                values: new object[,]
                {
                    { new Guid("070a2afb-be78-439a-9f03-d55be60dc134"), new Guid("1a4b34b8-2752-4062-a0e5-59695a79d9c7"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Bâton", null, null, 1, null, null },
                    { new Guid("0fdf20f9-4279-4fe7-a73c-4ba7d4fdb5be"), new Guid("6e3fd8e2-1680-4a8b-b928-1e48acc20861"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Dague", null, null, 1, null, null },
                    { new Guid("307de95a-45fd-45d0-9e6d-00554ac8f63d"), new Guid("f5d228cd-75ee-4462-a2a7-102383250bdd"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Marteau ou masse de guerre", null, null, 1, null, null },
                    { new Guid("4ffa6680-d4c9-49c7-a29c-04b7c53560e9"), new Guid("1a4b34b8-2752-4062-a0e5-59695a79d9c7"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Grimoire", null, null, null, null, null },
                    { new Guid("51eb1cf4-819e-4ce7-8f9f-7fd11342dbdb"), new Guid("7b00f70a-4e76-4d4c-8df5-c7ffe0022c20"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Dague", null, null, 1, null, null },
                    { new Guid("61621a26-7c3e-48a2-84f3-d61a76442657"), new Guid("ded836b7-688e-4757-b100-1dc146142846"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Dague", null, null, 1, null, null },
                    { new Guid("61fcd1a9-4b67-4afa-a7bb-caee1f26fc34"), new Guid("c67e5709-a257-4dcd-9250-6c2786327091"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Dague", null, null, 1, null, null },
                    { new Guid("694d75ca-3359-4c28-8090-9c0e61a120e4"), new Guid("a91093ab-cdec-4d36-8e30-9393a955c382"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Dague", null, null, 1, null, null },
                    { new Guid("6ec5814d-5d81-4663-b4fd-64c387533e1c"), new Guid("a91093ab-cdec-4d36-8e30-9393a955c382"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Arc court", null, null, 1, 30, null },
                    { new Guid("777d590e-1e13-45fe-91ff-0a422c049179"), new Guid("b27608e8-b453-4397-8d41-7c3c3d9af293"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Grand bouclier", null, 2, null, null, null },
                    { new Guid("7888a9a2-d597-4a0f-8cbb-ccb6e5422f95"), new Guid("c67e5709-a257-4dcd-9250-6c2786327091"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Épée longue", null, null, 1, null, null },
                    { new Guid("7da8f40c-da14-4e51-804b-9a27af8b9741"), new Guid("b27608e8-b453-4397-8d41-7c3c3d9af293"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Épée longue", null, null, 1, null, null },
                    { new Guid("94b9f9a9-bd23-46e5-863d-b3b5b63d1f6c"), new Guid("0441eff4-f2ca-4757-b02e-3e1043cf4234"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Rapière", 19, null, 1, null, null },
                    { new Guid("9b57d933-1e10-4db7-84fc-5000ca09b095"), new Guid("c67e5709-a257-4dcd-9250-6c2786327091"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Lance de cavalerie", null, null, 2, null, null },
                    { new Guid("a2fbf4a2-79c9-4a67-82e5-871e3f8db310"), new Guid("e6d9a3ba-1dcc-4e33-859f-615dbbf3717f"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Bâton ferré", null, null, 1, null, null },
                    { new Guid("a6c8a462-465c-4b63-b2bd-4ffd608fb3e9"), new Guid("a91093ab-cdec-4d36-8e30-9393a955c382"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Bâton", null, null, 1, null, null },
                    { new Guid("aa4f1bdb-8ba9-4030-a05a-573f468b5206"), new Guid("f5d228cd-75ee-4462-a2a7-102383250bdd"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Petit bouclier", null, 1, null, null, null },
                    { new Guid("b97ec6da-26a1-45fa-af1a-278352a3216f"), new Guid("6e3fd8e2-1680-4a8b-b928-1e48acc20861"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Épée longue", null, null, 1, null, null },
                    { new Guid("bb7c369a-6100-4489-a322-d09a5ed6b817"), new Guid("c67e5709-a257-4dcd-9250-6c2786327091"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Grand bouclier", null, 2, null, null, null },
                    { new Guid("be17ea3b-4132-468e-9bb4-b58ae3921e48"), new Guid("0441eff4-f2ca-4757-b02e-3e1043cf4234"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Outils de crochetage", null, null, null, null, null },
                    { new Guid("c376c16c-9a4a-4207-9c90-4a567d58753e"), new Guid("2048962d-f0d3-460b-a054-fae5ea578cc3"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Bâton ferré", null, null, 1, null, null },
                    { new Guid("c8e989c4-158b-4ba6-8d6c-822299afc517"), new Guid("7b00f70a-4e76-4d4c-8df5-c7ffe0022c20"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Marteau", null, null, 1, null, null },
                    { new Guid("cd0de432-6a9d-4eb3-b2b4-62834f8684fa"), new Guid("0441eff4-f2ca-4757-b02e-3e1043cf4234"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Dague de jet", null, null, 1, null, 5 },
                    { new Guid("cdf4943d-fedf-4b6c-bdcd-e48756543cb3"), new Guid("6e3fd8e2-1680-4a8b-b928-1e48acc20861"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Arc court", null, null, 1, 30, null },
                    { new Guid("ce5fe204-9c4d-4b53-ac11-00c6b2c0ee6f"), new Guid("7b00f70a-4e76-4d4c-8df5-c7ffe0022c20"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Bâton ferré", null, null, 1, null, null },
                    { new Guid("d5c3180c-dc53-4a22-9983-029f419c3675"), new Guid("b27608e8-b453-4397-8d41-7c3c3d9af293"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Épée ou hache à 2 mains", null, null, 2, null, null },
                    { new Guid("db9a9371-b414-4bb6-9263-aef7ef3377f1"), new Guid("ded836b7-688e-4757-b100-1dc146142846"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Bâton ferré", null, null, 1, null, null },
                    { new Guid("e00ea4c0-9a49-4188-9561-5fd7851dbc2c"), new Guid("2048962d-f0d3-460b-a054-fae5ea578cc3"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Dague", null, null, 1, null, null },
                    { new Guid("e2f5f54a-eb6e-4656-bf62-12fd17fd4a79"), new Guid("6e3fd8e2-1680-4a8b-b928-1e48acc20861"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Carquois", null, null, null, null, null },
                    { new Guid("f4c633bb-6ba5-4af7-b971-6700e7a9b5bc"), new Guid("1a4b34b8-2752-4062-a0e5-59695a79d9c7"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Dague", null, null, 1, null, null }
                });

            migrationBuilder.InsertData(
                table: "SoinStart",
                columns: new[] { "Id", "ClasseId", "DateCrea", "DateMaj", "DeSoin", "Libelle", "MinCritique", "NombreDeSoin" },
                values: new object[,]
                {
                    { new Guid("29224826-839b-4766-8326-34dedfcb59ce"), new Guid("ded836b7-688e-4757-b100-1dc146142846"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Potion de soins", null, 1 },
                    { new Guid("9add0625-5c5f-461a-a2d7-72381ae57e07"), new Guid("1a4b34b8-2752-4062-a0e5-59695a79d9c7"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Potion de soins", null, 1 },
                    { new Guid("efa42275-f8a6-4c3b-aba0-ec97c6de1a23"), new Guid("2048962d-f0d3-460b-a054-fae5ea578cc3"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Potion de soins", null, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("070a2afb-be78-439a-9f03-d55be60dc134"));

            migrationBuilder.DeleteData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("0fdf20f9-4279-4fe7-a73c-4ba7d4fdb5be"));

            migrationBuilder.DeleteData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("307de95a-45fd-45d0-9e6d-00554ac8f63d"));

            migrationBuilder.DeleteData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("4ffa6680-d4c9-49c7-a29c-04b7c53560e9"));

            migrationBuilder.DeleteData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("51eb1cf4-819e-4ce7-8f9f-7fd11342dbdb"));

            migrationBuilder.DeleteData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("61621a26-7c3e-48a2-84f3-d61a76442657"));

            migrationBuilder.DeleteData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("61fcd1a9-4b67-4afa-a7bb-caee1f26fc34"));

            migrationBuilder.DeleteData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("694d75ca-3359-4c28-8090-9c0e61a120e4"));

            migrationBuilder.DeleteData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("6ec5814d-5d81-4663-b4fd-64c387533e1c"));

            migrationBuilder.DeleteData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("777d590e-1e13-45fe-91ff-0a422c049179"));

            migrationBuilder.DeleteData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("7888a9a2-d597-4a0f-8cbb-ccb6e5422f95"));

            migrationBuilder.DeleteData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("7da8f40c-da14-4e51-804b-9a27af8b9741"));

            migrationBuilder.DeleteData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("94b9f9a9-bd23-46e5-863d-b3b5b63d1f6c"));

            migrationBuilder.DeleteData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("9b57d933-1e10-4db7-84fc-5000ca09b095"));

            migrationBuilder.DeleteData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("a2fbf4a2-79c9-4a67-82e5-871e3f8db310"));

            migrationBuilder.DeleteData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("a6c8a462-465c-4b63-b2bd-4ffd608fb3e9"));

            migrationBuilder.DeleteData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("aa4f1bdb-8ba9-4030-a05a-573f468b5206"));

            migrationBuilder.DeleteData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("b97ec6da-26a1-45fa-af1a-278352a3216f"));

            migrationBuilder.DeleteData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("bb7c369a-6100-4489-a322-d09a5ed6b817"));

            migrationBuilder.DeleteData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("be17ea3b-4132-468e-9bb4-b58ae3921e48"));

            migrationBuilder.DeleteData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("c376c16c-9a4a-4207-9c90-4a567d58753e"));

            migrationBuilder.DeleteData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("c8e989c4-158b-4ba6-8d6c-822299afc517"));

            migrationBuilder.DeleteData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("cd0de432-6a9d-4eb3-b2b4-62834f8684fa"));

            migrationBuilder.DeleteData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("cdf4943d-fedf-4b6c-bdcd-e48756543cb3"));

            migrationBuilder.DeleteData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("ce5fe204-9c4d-4b53-ac11-00c6b2c0ee6f"));

            migrationBuilder.DeleteData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("d5c3180c-dc53-4a22-9983-029f419c3675"));

            migrationBuilder.DeleteData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("db9a9371-b414-4bb6-9263-aef7ef3377f1"));

            migrationBuilder.DeleteData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("e00ea4c0-9a49-4188-9561-5fd7851dbc2c"));

            migrationBuilder.DeleteData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("e2f5f54a-eb6e-4656-bf62-12fd17fd4a79"));

            migrationBuilder.DeleteData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("f4c633bb-6ba5-4af7-b971-6700e7a9b5bc"));

            migrationBuilder.DeleteData(
                table: "SoinStart",
                keyColumn: "Id",
                keyValue: new Guid("29224826-839b-4766-8326-34dedfcb59ce"));

            migrationBuilder.DeleteData(
                table: "SoinStart",
                keyColumn: "Id",
                keyValue: new Guid("9add0625-5c5f-461a-a2d7-72381ae57e07"));

            migrationBuilder.DeleteData(
                table: "SoinStart",
                keyColumn: "Id",
                keyValue: new Guid("efa42275-f8a6-4c3b-aba0-ec97c6de1a23"));

            migrationBuilder.DropColumn(
                name: "ModificateurDef",
                table: "ArmeStart");

            migrationBuilder.DropColumn(
                name: "NombreDeAttaque",
                table: "ArmeStart");

            migrationBuilder.RenameColumn(
                name: "NombreDeSoin",
                table: "SoinStart",
                newName: "NumbreDeSoin");

            migrationBuilder.RenameColumn(
                name: "Quantite",
                table: "ArmeStart",
                newName: "NumbreDeAttaque");

            migrationBuilder.UpdateData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("626b4cbc-24fd-4cf4-b0b8-6ce09644a9e1"),
                column: "NumbreDeAttaque",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("739f46e1-8ef3-4f2a-926a-b5a04ad8d867"),
                column: "NumbreDeAttaque",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("7b82ed7e-ba93-4373-939e-28ac1721c088"),
                columns: new[] { "Libelle", "NumbreDeAttaque" },
                values: new object[] { "Epée longue", 1 });

            migrationBuilder.UpdateData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("9e473523-4c62-42c1-884b-e7f72048894a"),
                column: "NumbreDeAttaque",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("bf7e1989-9173-4e2c-84c3-0a12f089c3e1"),
                column: "NumbreDeAttaque",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("deedd7e0-f790-4ada-b987-d95b9c09d45b"),
                columns: new[] { "Libelle", "NumbreDeAttaque" },
                values: new object[] { "Rapiere", 1 });

            migrationBuilder.UpdateData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("e71e64ca-b497-45dc-b4b3-40f89a28540e"),
                column: "NumbreDeAttaque",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ArmeStart",
                keyColumn: "Id",
                keyValue: new Guid("fd4b96f6-715a-43ab-9113-3cc1273aa66b"),
                column: "NumbreDeAttaque",
                value: 2);
        }
    }
}
