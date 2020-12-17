using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GreenGo.DB.API.Migrations
{
    public partial class FirstEntry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Panels",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Power = table.Column<double>(nullable: false),
                    height = table.Column<double>(nullable: false),
                    width = table.Column<double>(nullable: false),
                    Company = table.Column<string>(nullable: false),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Panels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SolarStations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolarStations", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Panels",
                columns: new[] { "Id", "Company", "Power", "Price", "height", "width" },
                values: new object[,]
                {
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "Green Life", 45.0, 4500.0, 40.0, 50.0 },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"), "Yellow Life", 60.0, 7500.0, 50.0, 50.0 },
                    { new Guid("2902b665-1190-4c70-9915-b9c2d7680450"), "Blue Life", 70.0, 9500.0, 60.0, 60.0 },
                    { new Guid("102b566b-ba1f-404c-b2df-e2cde39ade09"), "Violet Life", 100.0, 10500.0, 90.0, 80.0 }
                });

            migrationBuilder.InsertData(
                table: "SolarStations",
                column: "Id",
                value: new Guid("f0449048-6210-4c37-aa97-60e61610ef1b"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Panels");

            migrationBuilder.DropTable(
                name: "SolarStations");
        }
    }
}
