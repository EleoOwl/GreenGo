using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GreenGo.DB.API.Migrations
{
    public partial class Revive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SolarStations",
                keyColumn: "Id",
                keyValue: new Guid("f876a7a6-40bb-4437-a7b4-4d530b383c78"));

            migrationBuilder.CreateTable(
                name: "Inverters",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Power = table.Column<double>(nullable: false),
                    Company = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inverters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReferenceTables",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IdInverter = table.Column<Guid>(nullable: false),
                    IdStation = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferenceTables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WindTurbines",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Matherial = table.Column<string>(nullable: true),
                    defPower = table.Column<double>(nullable: false),
                    Diameter = table.Column<double>(nullable: false),
                    numBlades = table.Column<int>(nullable: false),
                    Company = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WindTurbines", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Inverters",
                columns: new[] { "Id", "Company", "Power", "Price" },
                values: new object[,]
                {
                    { new Guid("eeb5c5f4-7a88-481f-81eb-2e62abe83b96"), null, 0.0, 0.0 },
                    { new Guid("7dcf1e76-6bd6-4fb7-8647-91f5497ac233"), null, 0.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "ReferenceTables",
                columns: new[] { "Id", "IdInverter", "IdStation" },
                values: new object[] { new Guid("26a2242a-659d-4158-ac39-fdbd29c576e2"), new Guid("f29d507a-b388-4cf3-8659-a3ee30e31ac6"), new Guid("e8653222-a6ba-421c-824b-40ec0b642d2a") });

            migrationBuilder.InsertData(
                table: "SolarStations",
                column: "Id",
                value: new Guid("17046f99-fdb3-437b-ae20-cc39dd7ee12e"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inverters");

            migrationBuilder.DropTable(
                name: "ReferenceTables");

            migrationBuilder.DropTable(
                name: "WindTurbines");

            migrationBuilder.DeleteData(
                table: "SolarStations",
                keyColumn: "Id",
                keyValue: new Guid("17046f99-fdb3-437b-ae20-cc39dd7ee12e"));

            migrationBuilder.InsertData(
                table: "SolarStations",
                column: "Id",
                value: new Guid("f876a7a6-40bb-4437-a7b4-4d530b383c78"));
        }
    }
}
