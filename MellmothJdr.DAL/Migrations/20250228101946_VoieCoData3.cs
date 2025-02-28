using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MellmothJdr.DAL.Migrations
{
    /// <inheritdoc />
    public partial class VoieCoData3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "VoieChroniquesOublies",
                columns: new[] { "Id", "ClasseId", "DateCrea", "DateMaj", "Libelle" },
                values: new object[,]
                {
                    { new Guid("19d16644-0aa1-4379-aaf7-196376007772"), new Guid("f5d228cd-75ee-4462-a2a7-102383250bdd"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie de la guerre" },
                    { new Guid("1be9f71e-99a8-4a5b-a93c-95096ea6e685"), new Guid("e6d9a3ba-1dcc-4e33-859f-615dbbf3717f"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie de la maîtrise" },
                    { new Guid("1cf09568-5bfc-48a5-8371-df419a554869"), new Guid("1a4b34b8-2752-4062-a0e5-59695a79d9c7"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie de la magie destructrice" },
                    { new Guid("1ecb8777-04ff-48b9-a51d-a92e17fcfa2d"), new Guid("0441eff4-f2ca-4757-b02e-3e1043cf4234"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie de l’aventurier" },
                    { new Guid("25af40ce-083a-4e2d-bdc3-d72342e3a149"), new Guid("f5d228cd-75ee-4462-a2a7-102383250bdd"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie de la foi" },
                    { new Guid("2823a719-d3a3-43fe-b842-dcd24513964b"), new Guid("6e3fd8e2-1680-4a8b-b928-1e48acc20861"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie du traqueur" },
                    { new Guid("2a304b61-c660-4507-8e5d-b565f89462d2"), new Guid("e6d9a3ba-1dcc-4e33-859f-615dbbf3717f"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie de la méditation" },
                    { new Guid("31d4b168-739a-424e-9d5c-fbf9bed776eb"), new Guid("6e3fd8e2-1680-4a8b-b928-1e48acc20861"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie de l’archer" },
                    { new Guid("35e3c04d-de8d-4ec1-a4e1-81e797545579"), new Guid("0441eff4-f2ca-4757-b02e-3e1043cf4234"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie du roublard" },
                    { new Guid("45247844-6883-426d-a301-d129bebf4f3a"), new Guid("0441eff4-f2ca-4757-b02e-3e1043cf4234"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie du déplacement" },
                    { new Guid("4759b912-a754-433b-8e34-a1a985d570a6"), new Guid("e6d9a3ba-1dcc-4e33-859f-615dbbf3717f"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie de l’énergie vitale" },
                    { new Guid("4768bf3a-f1da-4e09-af9e-d82766108d25"), new Guid("6e3fd8e2-1680-4a8b-b928-1e48acc20861"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie de l’escarmouche" },
                    { new Guid("4b4ced79-95f3-4107-9870-e92aab440c49"), new Guid("ded836b7-688e-4757-b100-1dc146142846"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie de la mort" },
                    { new Guid("4cfa800e-b320-48c1-b5f0-3729c3dda901"), new Guid("6e3fd8e2-1680-4a8b-b928-1e48acc20861"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie de la survie" },
                    { new Guid("4e271e7d-3a6b-4060-b033-8b98a7d04bf7"), new Guid("b27608e8-b453-4397-8d41-7c3c3d9af293"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie du soldat" },
                    { new Guid("5244ff62-6c95-4ffd-b5a6-39ac435a2922"), new Guid("6e3fd8e2-1680-4a8b-b928-1e48acc20861"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie du montreur d’ours" },
                    { new Guid("54516d5f-6afe-4a03-a36f-45c1a29ea573"), new Guid("ded836b7-688e-4757-b100-1dc146142846"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie du démon" },
                    { new Guid("59231f1d-b441-404d-a313-cfed79971428"), new Guid("7b00f70a-4e76-4d4c-8df5-c7ffe0022c20"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie du métal" },
                    { new Guid("6ecdaa1f-0ed7-410c-b113-467461811b28"), new Guid("ded836b7-688e-4757-b100-1dc146142846"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie de la sombre magie" },
                    { new Guid("6f96951a-e0b1-4b33-a3f1-d8d6038ec296"), new Guid("b27608e8-b453-4397-8d41-7c3c3d9af293"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie du combat" },
                    { new Guid("71c3e812-2e10-43ea-8173-f3d6e54647c6"), new Guid("b27608e8-b453-4397-8d41-7c3c3d9af293"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie du bouclier" },
                    { new Guid("7464a48a-2422-4403-82a6-a3ab1dab957a"), new Guid("6e3fd8e2-1680-4a8b-b928-1e48acc20861"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie du compagnon animal" },
                    { new Guid("81b9d4ed-1cd9-4ee5-a3b0-8b2610a32e82"), new Guid("ded836b7-688e-4757-b100-1dc146142846"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie du sang" },
                    { new Guid("8b600d39-44e3-4d4b-9ddc-548cf6a75205"), new Guid("ded836b7-688e-4757-b100-1dc146142846"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie de l’outre-tombe" },
                    { new Guid("9ec521ed-a5a7-4446-862f-c3e3485474c3"), new Guid("e6d9a3ba-1dcc-4e33-859f-615dbbf3717f"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie du vent" },
                    { new Guid("a1fb9733-785e-409d-9890-b9483530dfc6"), new Guid("0441eff4-f2ca-4757-b02e-3e1043cf4234"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie de l’assassin" },
                    { new Guid("a2c12d80-78af-42d7-afe4-85631151f043"), new Guid("1a4b34b8-2752-4062-a0e5-59695a79d9c7"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie de la magie protectrice" },
                    { new Guid("a33d2b95-b078-4931-90db-fdf762806afe"), new Guid("1a4b34b8-2752-4062-a0e5-59695a79d9c7"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie de la magie élémentaire" },
                    { new Guid("acc69e02-e4ea-4958-9334-d7cd3d5c4fce"), new Guid("b27608e8-b453-4397-8d41-7c3c3d9af293"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie du maître d'armes" },
                    { new Guid("b16a7caf-1e14-45b2-bedc-2f6c472b9135"), new Guid("f5d228cd-75ee-4462-a2a7-102383250bdd"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie de la prière" },
                    { new Guid("b6ccc6fc-7bed-4c4d-a295-631581d7fdd9"), new Guid("e6d9a3ba-1dcc-4e33-859f-615dbbf3717f"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie du poing" },
                    { new Guid("c8a1ba87-c028-4360-a54a-de60bc9019fe"), new Guid("f5d228cd-75ee-4462-a2a7-102383250bdd"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie de la spiritualité" },
                    { new Guid("cfd85b3e-b0d1-4da9-a63c-db843e10415c"), new Guid("7b00f70a-4e76-4d4c-8df5-c7ffe0022c20"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie des artefacts" },
                    { new Guid("d5b96164-b70f-4e70-bf16-44e70e53c0cf"), new Guid("7b00f70a-4e76-4d4c-8df5-c7ffe0022c20"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie du golem" },
                    { new Guid("d642eda0-f216-4fa6-ba1a-adb20d5f5a70"), new Guid("7b00f70a-4e76-4d4c-8df5-c7ffe0022c20"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie des runes" },
                    { new Guid("db5e27d2-4960-4bfe-8ed6-b30ad9564661"), new Guid("0441eff4-f2ca-4757-b02e-3e1043cf4234"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie du spadassin" },
                    { new Guid("e339151c-7dfd-4adf-abf8-c92a52d679cf"), new Guid("1a4b34b8-2752-4062-a0e5-59695a79d9c7"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie de la magie des arcanes" },
                    { new Guid("f51af3e7-73a0-43c8-9b25-1f04bc5b07fd"), new Guid("f5d228cd-75ee-4462-a2a7-102383250bdd"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie des soins" },
                    { new Guid("f5b824ec-f37e-4c83-869e-3db271170855"), new Guid("b27608e8-b453-4397-8d41-7c3c3d9af293"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie de la résistance" },
                    { new Guid("fb1ee967-6b28-467a-b9e7-01dc6819c94c"), new Guid("7b00f70a-4e76-4d4c-8df5-c7ffe0022c20"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie des élixirs" },
                    { new Guid("fee00c48-7283-4f2b-87f5-a5a1cb589acf"), new Guid("1a4b34b8-2752-4062-a0e5-59695a79d9c7"), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voie de la magie universelle" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("19d16644-0aa1-4379-aaf7-196376007772"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("1be9f71e-99a8-4a5b-a93c-95096ea6e685"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("1cf09568-5bfc-48a5-8371-df419a554869"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("1ecb8777-04ff-48b9-a51d-a92e17fcfa2d"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("25af40ce-083a-4e2d-bdc3-d72342e3a149"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("2823a719-d3a3-43fe-b842-dcd24513964b"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("2a304b61-c660-4507-8e5d-b565f89462d2"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("31d4b168-739a-424e-9d5c-fbf9bed776eb"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("35e3c04d-de8d-4ec1-a4e1-81e797545579"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("45247844-6883-426d-a301-d129bebf4f3a"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("4759b912-a754-433b-8e34-a1a985d570a6"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("4768bf3a-f1da-4e09-af9e-d82766108d25"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("4b4ced79-95f3-4107-9870-e92aab440c49"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("4cfa800e-b320-48c1-b5f0-3729c3dda901"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("4e271e7d-3a6b-4060-b033-8b98a7d04bf7"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("5244ff62-6c95-4ffd-b5a6-39ac435a2922"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("54516d5f-6afe-4a03-a36f-45c1a29ea573"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("59231f1d-b441-404d-a313-cfed79971428"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("6ecdaa1f-0ed7-410c-b113-467461811b28"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("6f96951a-e0b1-4b33-a3f1-d8d6038ec296"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("71c3e812-2e10-43ea-8173-f3d6e54647c6"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("7464a48a-2422-4403-82a6-a3ab1dab957a"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("81b9d4ed-1cd9-4ee5-a3b0-8b2610a32e82"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("8b600d39-44e3-4d4b-9ddc-548cf6a75205"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("9ec521ed-a5a7-4446-862f-c3e3485474c3"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("a1fb9733-785e-409d-9890-b9483530dfc6"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("a2c12d80-78af-42d7-afe4-85631151f043"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("a33d2b95-b078-4931-90db-fdf762806afe"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("acc69e02-e4ea-4958-9334-d7cd3d5c4fce"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("b16a7caf-1e14-45b2-bedc-2f6c472b9135"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("b6ccc6fc-7bed-4c4d-a295-631581d7fdd9"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("c8a1ba87-c028-4360-a54a-de60bc9019fe"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("cfd85b3e-b0d1-4da9-a63c-db843e10415c"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("d5b96164-b70f-4e70-bf16-44e70e53c0cf"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("d642eda0-f216-4fa6-ba1a-adb20d5f5a70"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("db5e27d2-4960-4bfe-8ed6-b30ad9564661"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("e339151c-7dfd-4adf-abf8-c92a52d679cf"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("f51af3e7-73a0-43c8-9b25-1f04bc5b07fd"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("f5b824ec-f37e-4c83-869e-3db271170855"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("fb1ee967-6b28-467a-b9e7-01dc6819c94c"));

            migrationBuilder.DeleteData(
                table: "VoieChroniquesOublies",
                keyColumn: "Id",
                keyValue: new Guid("fee00c48-7283-4f2b-87f5-a5a1cb589acf"));
        }
    }
}
