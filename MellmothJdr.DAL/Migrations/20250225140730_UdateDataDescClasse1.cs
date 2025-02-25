using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MellmothJdr.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UdateDataDescClasse1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("88a45295-7a95-487e-b881-fb9e0580a2a5"),
                column: "Description",
                value: "L’Arquebusier est un dur à cuire, un soldat ou un mercenaire habitué des champs de bataille. C’est un spécialiste du combat à distance et plus particulièrement des armes à feu et des explosifs.");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("c67e5709-a257-4dcd-9250-6c2786327091"),
                column: "Description",
                value: "Le Chevalier est un noble guerrier errant, monté sur un puissant destrier et protégé par une armure lourde. Il parcourt la campagne en quête de torts à redresser et d’occasions de mettre son courage à l’épreuve.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("88a45295-7a95-487e-b881-fb9e0580a2a5"),
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("c67e5709-a257-4dcd-9250-6c2786327091"),
                column: "Description",
                value: null);
        }
    }
}
