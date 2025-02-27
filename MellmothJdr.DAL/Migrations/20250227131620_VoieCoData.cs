using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MellmothJdr.DAL.Migrations
{
    /// <inheritdoc />
    public partial class VoieCoData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "VoieChroniquesOublies",
                columns: new[] { "Id", "ClasseId", "DateCrea", "DateMaj", "Description", "Libelle" },
                values: new object[,]
                {
                    { new Guid("47788de0-28be-470f-b149-5ed087db1f3a"), new Guid("c67e5709-a257-4dcd-9250-6c2786327091"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie de la guerre", "Voie de la guerre" },
                    { new Guid("80449956-ec6c-4df1-b15c-27f99879be26"), new Guid("c67e5709-a257-4dcd-9250-6c2786327091"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie du meneur d'home", "Voie du meneur d'home" },
                    { new Guid("c215d7a1-dc5c-4e6d-96e2-684c4c68d73f"), new Guid("c67e5709-a257-4dcd-9250-6c2786327091"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie du Cavalier", "Voie du Cavalier" },
                    { new Guid("ef0fc838-dfc8-4b86-a91f-1cacd56375d1"), new Guid("c67e5709-a257-4dcd-9250-6c2786327091"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie du héro", "Voie du héro" },
                    { new Guid("f09f1552-4ac4-4dd3-bef5-da23e25f7d14"), new Guid("c67e5709-a257-4dcd-9250-6c2786327091"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie de la noblesse", "Voie de la noblesse" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("47788de0-28be-470f-b149-5ed087db1f3a"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("80449956-ec6c-4df1-b15c-27f99879be26"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("c215d7a1-dc5c-4e6d-96e2-684c4c68d73f"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("ef0fc838-dfc8-4b86-a91f-1cacd56375d1"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("f09f1552-4ac4-4dd3-bef5-da23e25f7d14"));
        }
    }
}
