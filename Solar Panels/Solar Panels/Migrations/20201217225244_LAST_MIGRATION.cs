using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GreenGo.DB.API.Migrations
{
    public partial class LAST_MIGRATION : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Inverters",
                keyColumn: "Id",
                keyValue: new Guid("abd086ce-9949-478e-9115-a1eabb24b799"));

            migrationBuilder.DeleteData(
                table: "Inverters",
                keyColumn: "Id",
                keyValue: new Guid("edfa3244-14dd-4ab0-8357-a8c70b956299"));

            migrationBuilder.DeleteData(
                table: "ReferenceTables",
                keyColumn: "Id",
                keyValue: new Guid("7b77955c-17e8-42a5-bc91-2406b5a1dea9"));

            migrationBuilder.DeleteData(
                table: "SolarStations",
                keyColumn: "Id",
                keyValue: new Guid("5499038b-1e18-48ea-9fd0-1a61f97a727e"));

            migrationBuilder.RenameColumn(
                name: "IdInverter",
                table: "ReferenceTables",
                newName: "IdPanel");

            migrationBuilder.AddColumn<Guid>(
                name: "IdInverter",
                table: "SolarStations",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Inverters",
                columns: new[] { "Id", "Company", "Power", "Price" },
                values: new object[,]
                {
                    { new Guid("92a42ce5-f8e0-4eb5-925f-8fb654d7bae5"), "not THE BEST COMPANY", 24.0, 8000.0 },
                    { new Guid("f563340f-2340-45df-b4df-de0903d960ea"), null, 0.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "ReferenceTables",
                columns: new[] { "Id", "IdPanel", "IdStation" },
                values: new object[] { new Guid("ecf86545-e36d-462e-afdd-c2d88a06f276"), new Guid("102b566b-ba1f-404c-b2df-e2cde39ade09"), new Guid("102b566b-ba1f-404c-b2df-e2cde39ade12") });

            migrationBuilder.InsertData(
                table: "SolarStations",
                columns: new[] { "Id", "IdInverter" },
                values: new object[] { new Guid("102b566b-ba1f-404c-b2df-e2cde39ade12"), new Guid("00000000-0000-0000-0000-000000000000") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Inverters",
                keyColumn: "Id",
                keyValue: new Guid("92a42ce5-f8e0-4eb5-925f-8fb654d7bae5"));

            migrationBuilder.DeleteData(
                table: "Inverters",
                keyColumn: "Id",
                keyValue: new Guid("f563340f-2340-45df-b4df-de0903d960ea"));

            migrationBuilder.DeleteData(
                table: "ReferenceTables",
                keyColumn: "Id",
                keyValue: new Guid("ecf86545-e36d-462e-afdd-c2d88a06f276"));

            migrationBuilder.DeleteData(
                table: "SolarStations",
                keyColumn: "Id",
                keyValue: new Guid("102b566b-ba1f-404c-b2df-e2cde39ade12"));

            migrationBuilder.DropColumn(
                name: "IdInverter",
                table: "SolarStations");

            migrationBuilder.RenameColumn(
                name: "IdPanel",
                table: "ReferenceTables",
                newName: "IdInverter");

            migrationBuilder.InsertData(
                table: "Inverters",
                columns: new[] { "Id", "Company", "Power", "Price" },
                values: new object[,]
                {
                    { new Guid("abd086ce-9949-478e-9115-a1eabb24b799"), null, 0.0, 0.0 },
                    { new Guid("edfa3244-14dd-4ab0-8357-a8c70b956299"), null, 0.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "ReferenceTables",
                columns: new[] { "Id", "IdInverter", "IdStation" },
                values: new object[] { new Guid("7b77955c-17e8-42a5-bc91-2406b5a1dea9"), new Guid("0263a551-f3fe-4b9b-9cb0-4d25008ca057"), new Guid("d7306d10-f41f-420d-8194-a7d5dbe9216f") });

            migrationBuilder.InsertData(
                table: "SolarStations",
                column: "Id",
                value: new Guid("5499038b-1e18-48ea-9fd0-1a61f97a727e"));
        }
    }
}
