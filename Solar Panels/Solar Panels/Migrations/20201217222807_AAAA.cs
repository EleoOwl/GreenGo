using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GreenGo.DB.API.Migrations
{
    public partial class AAAA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Inverters",
                keyColumn: "Id",
                keyValue: new Guid("127657a5-eacc-4fbc-bc9a-ebf3b19be76b"));

            migrationBuilder.DeleteData(
                table: "Inverters",
                keyColumn: "Id",
                keyValue: new Guid("ca31fd21-68ba-4784-9a70-35fe76876a73"));

            migrationBuilder.DeleteData(
                table: "ReferenceTables",
                keyColumn: "Id",
                keyValue: new Guid("a8f6895f-d455-438d-beda-93538c597aca"));

            migrationBuilder.DeleteData(
                table: "SolarStations",
                keyColumn: "Id",
                keyValue: new Guid("d5b18e89-0b44-4132-93f5-0e5276eb2c88"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Inverters",
                columns: new[] { "Id", "Company", "Power", "Price" },
                values: new object[,]
                {
                    { new Guid("127657a5-eacc-4fbc-bc9a-ebf3b19be76b"), null, 0.0, 0.0 },
                    { new Guid("ca31fd21-68ba-4784-9a70-35fe76876a73"), null, 0.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "ReferenceTables",
                columns: new[] { "Id", "IdInverter", "IdStation" },
                values: new object[] { new Guid("a8f6895f-d455-438d-beda-93538c597aca"), new Guid("753fdc73-7f9f-4f4f-bd57-031de0a9ee2b"), new Guid("1640da65-06e5-491a-8aec-86f5b62538c2") });

            migrationBuilder.InsertData(
                table: "SolarStations",
                column: "Id",
                value: new Guid("d5b18e89-0b44-4132-93f5-0e5276eb2c88"));
        }
    }
}
