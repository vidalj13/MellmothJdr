using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MellmothJdr.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Classes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ClasseId",
                table: "FichesPersoChroniquesOublies",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Libelle = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(max)", nullable: true),
                    JeuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCrea = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getutcdate()"),
                    DateMaj = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getutcdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Classes_Jeux_JeuId",
                        column: x => x.JeuId,
                        principalTable: "Jeux",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JoinFichePersoChroniquesOubliesClasses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClasseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FichePersoChroniquesOubliesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCrea = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getutcdate()"),
                    DateMaj = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getutcdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JoinFichePersoChroniquesOubliesClasses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JoinFichePersoChroniquesOubliesClasses_Classes_ClasseId",
                        column: x => x.ClasseId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JoinFichePersoChroniquesOubliesClasses_FichesPersoChroniquesOublies_FichePersoChroniquesOubliesId",
                        column: x => x.FichePersoChroniquesOubliesId,
                        principalTable: "FichesPersoChroniquesOublies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "DateCrea", "DateMaj", "Description", "JeuId", "Libelle" },
                values: new object[,]
                {
                    { new Guid("0441eff4-f2ca-4757-b02e-3e1043cf4234"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("1c474c24-f5c9-470e-9b91-046b639275c3"), "Voleur" },
                    { new Guid("0b7fd2d0-c2ad-4492-ab38-f741174d5a6d"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("1c474c24-f5c9-470e-9b91-046b639275c3"), "Barbare" },
                    { new Guid("1a4b34b8-2752-4062-a0e5-59695a79d9c7"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("1c474c24-f5c9-470e-9b91-046b639275c3"), "Magicien" },
                    { new Guid("2048962d-f0d3-460b-a054-fae5ea578cc3"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("1c474c24-f5c9-470e-9b91-046b639275c3"), "Ensorceleur" },
                    { new Guid("6e3fd8e2-1680-4a8b-b928-1e48acc20861"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("1c474c24-f5c9-470e-9b91-046b639275c3"), "Rôdeur" },
                    { new Guid("7b00f70a-4e76-4d4c-8df5-c7ffe0022c20"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("1c474c24-f5c9-470e-9b91-046b639275c3"), "Forgesort" },
                    { new Guid("88a45295-7a95-487e-b881-fb9e0580a2a5"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("1c474c24-f5c9-470e-9b91-046b639275c3"), "Arquebusier" },
                    { new Guid("91b825c3-3e5a-4e1b-8724-daf18ea27c6a"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("1c474c24-f5c9-470e-9b91-046b639275c3"), "Barde" },
                    { new Guid("a91093ab-cdec-4d36-8e30-9393a955c382"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("1c474c24-f5c9-470e-9b91-046b639275c3"), "Druide" },
                    { new Guid("b27608e8-b453-4397-8d41-7c3c3d9af293"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("1c474c24-f5c9-470e-9b91-046b639275c3"), "Guerrier" },
                    { new Guid("c67e5709-a257-4dcd-9250-6c2786327091"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("1c474c24-f5c9-470e-9b91-046b639275c3"), "Chevalier" },
                    { new Guid("ded836b7-688e-4757-b100-1dc146142846"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("1c474c24-f5c9-470e-9b91-046b639275c3"), "Nécromancien" },
                    { new Guid("e6d9a3ba-1dcc-4e33-859f-615dbbf3717f"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("1c474c24-f5c9-470e-9b91-046b639275c3"), "Moine" },
                    { new Guid("f5d228cd-75ee-4462-a2a7-102383250bdd"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("1c474c24-f5c9-470e-9b91-046b639275c3"), "Prêtre" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FichesPersoChroniquesOublies_ClasseId",
                table: "FichesPersoChroniquesOublies",
                column: "ClasseId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_JeuId",
                table: "Classes",
                column: "JeuId");

            migrationBuilder.CreateIndex(
                name: "IX_JoinFichePersoChroniquesOubliesClasses_ClasseId",
                table: "JoinFichePersoChroniquesOubliesClasses",
                column: "ClasseId");

            migrationBuilder.CreateIndex(
                name: "IX_JoinFichePersoChroniquesOubliesClasses_FichePersoChroniquesOubliesId",
                table: "JoinFichePersoChroniquesOubliesClasses",
                column: "FichePersoChroniquesOubliesId");

            migrationBuilder.AddForeignKey(
                name: "FK_FichesPersoChroniquesOublies_Classes_ClasseId",
                table: "FichesPersoChroniquesOublies",
                column: "ClasseId",
                principalTable: "Classes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FichesPersoChroniquesOublies_Classes_ClasseId",
                table: "FichesPersoChroniquesOublies");

            migrationBuilder.DropTable(
                name: "JoinFichePersoChroniquesOubliesClasses");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_FichesPersoChroniquesOublies_ClasseId",
                table: "FichesPersoChroniquesOublies");

            migrationBuilder.DropColumn(
                name: "ClasseId",
                table: "FichesPersoChroniquesOublies");
        }
    }
}
