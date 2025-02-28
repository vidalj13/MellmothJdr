using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MellmothJdr.DAL.Migrations
{
    /// <inheritdoc />
    public partial class VoieCoData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "VoieChroniquesOublies");

            migrationBuilder.InsertData(
                table: "VoieChroniquesOublies",
                columns: new[] { "Id", "ClasseId", "DateCrea", "DateMaj", "Libelle" },
                values: new object[,]
                {
                    { new Guid("0386a871-cf49-4077-9525-9426dc14116a"), new Guid("88a45295-7a95-487e-b881-fb9e0580a2a5"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie de l'artilleur" },
                    { new Guid("0b6dcbe7-1bbd-4be1-acec-c1da36e2211a"), new Guid("a91093ab-cdec-4d36-8e30-9393a955c382"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie de la nature" },
                    { new Guid("242d65cc-ec94-4924-b9f9-1b7da767be57"), new Guid("88a45295-7a95-487e-b881-fb9e0580a2a5"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie de la Précision" },
                    { new Guid("30d0645e-c314-4a2e-bbdf-027cb116bd48"), new Guid("91b825c3-3e5a-4e1b-8724-daf18ea27c6a"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie de l'escrime" },
                    { new Guid("323d7866-e565-4d85-9eac-e7cb4d9ae814"), new Guid("2048962d-f0d3-460b-a054-fae5ea578cc3"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie des illusions" },
                    { new Guid("3f9dc814-e5f8-4872-9b03-fc9a10a3c134"), new Guid("88a45295-7a95-487e-b881-fb9e0580a2a5"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie du pistolero" },
                    { new Guid("4b83c273-170d-4cdf-ba27-46ea7ee53104"), new Guid("0b7fd2d0-c2ad-4492-ab38-f741174d5a6d"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie de la brute" },
                    { new Guid("6522263c-bd63-43b4-b861-c6afc6b8c2df"), new Guid("0b7fd2d0-c2ad-4492-ab38-f741174d5a6d"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie de la rage" },
                    { new Guid("6526792f-73df-4bcd-93f4-61a118306e05"), new Guid("0b7fd2d0-c2ad-4492-ab38-f741174d5a6d"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie du primitif" },
                    { new Guid("6a50b874-a765-4c6d-8854-b391d8a446fa"), new Guid("88a45295-7a95-487e-b881-fb9e0580a2a5"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie des explosifs" },
                    { new Guid("83fd315f-81cb-4319-93c9-7592f591b9a3"), new Guid("a91093ab-cdec-4d36-8e30-9393a955c382"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie du protecteur" },
                    { new Guid("8437ddd7-3735-4ab3-9f2e-a36fa1c545ad"), new Guid("91b825c3-3e5a-4e1b-8724-daf18ea27c6a"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie du musicien" },
                    { new Guid("877805f5-6848-481e-91f9-5a73a12a6831"), new Guid("a91093ab-cdec-4d36-8e30-9393a955c382"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie des végétaux" },
                    { new Guid("88c40ede-afb8-4896-94f5-46006413f52e"), new Guid("a91093ab-cdec-4d36-8e30-9393a955c382"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie du fauve" },
                    { new Guid("896ce611-3ece-4efe-99d3-eb89f3cd8358"), new Guid("88a45295-7a95-487e-b881-fb9e0580a2a5"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie du champs de bataille" },
                    { new Guid("8ec3f722-c4ba-4686-93d4-7ddb429c766d"), new Guid("91b825c3-3e5a-4e1b-8724-daf18ea27c6a"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie de la séduction" },
                    { new Guid("a4f66035-8813-4cc2-baf2-68bd3245651c"), new Guid("91b825c3-3e5a-4e1b-8724-daf18ea27c6a"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie du saltimbanque" },
                    { new Guid("a68a8347-d8a3-4166-92f1-068542471942"), new Guid("0b7fd2d0-c2ad-4492-ab38-f741174d5a6d"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie du pagnes" },
                    { new Guid("abd8238a-53a7-4b6e-8c3d-284b51fcf822"), new Guid("2048962d-f0d3-460b-a054-fae5ea578cc3"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie de la divination" },
                    { new Guid("af7f4ed7-a88f-4770-b529-e86b60141789"), new Guid("91b825c3-3e5a-4e1b-8724-daf18ea27c6a"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie du vagabond" },
                    { new Guid("b24cf994-3b21-4835-a1ac-0555adc1a1da"), new Guid("2048962d-f0d3-460b-a054-fae5ea578cc3"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie de l'envoûteur" },
                    { new Guid("b8a9904a-a3bc-455a-a332-e4bb25019446"), new Guid("a91093ab-cdec-4d36-8e30-9393a955c382"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie des animaux" },
                    { new Guid("d3df1f26-acd5-4778-bfcb-2cfc5f13d32e"), new Guid("0b7fd2d0-c2ad-4492-ab38-f741174d5a6d"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie du pourfendeur" },
                    { new Guid("dce8ca92-fa58-4828-8422-f103ff74bd42"), new Guid("2048962d-f0d3-460b-a054-fae5ea578cc3"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie de l'invocation" },
                    { new Guid("ddb271b5-c0d0-4938-93bc-5af13f81eb6b"), new Guid("2048962d-f0d3-460b-a054-fae5ea578cc3"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie de l'air" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("0386a871-cf49-4077-9525-9426dc14116a"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("0b6dcbe7-1bbd-4be1-acec-c1da36e2211a"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("242d65cc-ec94-4924-b9f9-1b7da767be57"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("30d0645e-c314-4a2e-bbdf-027cb116bd48"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("323d7866-e565-4d85-9eac-e7cb4d9ae814"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("3f9dc814-e5f8-4872-9b03-fc9a10a3c134"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("4b83c273-170d-4cdf-ba27-46ea7ee53104"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("6522263c-bd63-43b4-b861-c6afc6b8c2df"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("6526792f-73df-4bcd-93f4-61a118306e05"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("6a50b874-a765-4c6d-8854-b391d8a446fa"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("83fd315f-81cb-4319-93c9-7592f591b9a3"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("8437ddd7-3735-4ab3-9f2e-a36fa1c545ad"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("877805f5-6848-481e-91f9-5a73a12a6831"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("88c40ede-afb8-4896-94f5-46006413f52e"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("896ce611-3ece-4efe-99d3-eb89f3cd8358"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("8ec3f722-c4ba-4686-93d4-7ddb429c766d"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("a4f66035-8813-4cc2-baf2-68bd3245651c"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("a68a8347-d8a3-4166-92f1-068542471942"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("abd8238a-53a7-4b6e-8c3d-284b51fcf822"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("af7f4ed7-a88f-4770-b529-e86b60141789"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("b24cf994-3b21-4835-a1ac-0555adc1a1da"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("b8a9904a-a3bc-455a-a332-e4bb25019446"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("d3df1f26-acd5-4778-bfcb-2cfc5f13d32e"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("dce8ca92-fa58-4828-8422-f103ff74bd42"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("ddb271b5-c0d0-4938-93bc-5af13f81eb6b"));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "VoieChroniquesOublies",
                type: "varchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("47788de0-28be-470f-b149-5ed087db1f3a"),
                column: "Description",
                value: "Voie de la guerre");

            migrationBuilder.UpdateData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("80449956-ec6c-4df1-b15c-27f99879be26"),
                column: "Description",
                value: "Voie du meneur d'home");

            migrationBuilder.UpdateData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("c215d7a1-dc5c-4e6d-96e2-684c4c68d73f"),
                column: "Description",
                value: "Voie du Cavalier");

            migrationBuilder.UpdateData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("ef0fc838-dfc8-4b86-a91f-1cacd56375d1"),
                column: "Description",
                value: "Voie du héro");

            migrationBuilder.UpdateData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("f09f1552-4ac4-4dd3-bef5-da23e25f7d14"),
                column: "Description",
                value: "Voie de la noblesse");
        }
    }
}
