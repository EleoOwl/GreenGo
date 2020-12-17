using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GreenGo.DB.API.Migrations
{
    public partial class OVER_LAST_MIGRATION : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Inverters",
                columns: new[] { "Id", "Company", "Power", "Price" },
                values: new object[,]
                {
                    { new Guid("15f8c53b-e896-4c7f-891b-31393cd1736d"), "not THE BEST COMPANY", 24.0, 8000.0 },
                    { new Guid("98c1c7d6-3afc-4ae9-9b0b-6c270676e65b"), "THE BEST COMPANY", 45.0, 10000.0 },
                    { new Guid("1f08fc57-42e4-4af1-9409-1a92d3318980"), "THE BEST COMPANY", 45.0, 10000.0 },
                    { new Guid("314bcebb-5583-4577-833e-7bb6a5e95ad0"), null, 0.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "ReferenceTables",
                columns: new[] { "Id", "IdPanel", "IdStation" },
                values: new object[] { new Guid("73bec3e5-e3ba-4f43-a706-c2eefa5ec9d4"), new Guid("2902b665-1190-4c70-9915-b9c2d7680450"), new Guid("5de324e0-203d-4478-8fb2-e19d686500eb") });

            migrationBuilder.InsertData(
                table: "SolarStations",
                columns: new[] { "Id", "IdInverter" },
                values: new object[,]
                {
                    { new Guid("5de324e0-203d-4478-8fb2-e19d686500eb"), new Guid("15f8c53b-e896-4c7f-891b-31393cd1736d") },
                    { new Guid("d5db0978-13b6-4ba6-a20a-777de3d9b660"), new Guid("98c1c7d6-3afc-4ae9-9b0b-6c270676e65b") },
                    { new Guid("c8e840fc-f108-4a75-bff6-099d7f979bd0"), new Guid("1f08fc57-42e4-4af1-9409-1a92d3318980") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Inverters",
                keyColumn: "Id",
                keyValue: new Guid("15f8c53b-e896-4c7f-891b-31393cd1736d"));

            migrationBuilder.DeleteData(
                table: "Inverters",
                keyColumn: "Id",
                keyValue: new Guid("1f08fc57-42e4-4af1-9409-1a92d3318980"));

            migrationBuilder.DeleteData(
                table: "Inverters",
                keyColumn: "Id",
                keyValue: new Guid("314bcebb-5583-4577-833e-7bb6a5e95ad0"));

            migrationBuilder.DeleteData(
                table: "Inverters",
                keyColumn: "Id",
                keyValue: new Guid("98c1c7d6-3afc-4ae9-9b0b-6c270676e65b"));

            migrationBuilder.DeleteData(
                table: "ReferenceTables",
                keyColumn: "Id",
                keyValue: new Guid("73bec3e5-e3ba-4f43-a706-c2eefa5ec9d4"));

            migrationBuilder.DeleteData(
                table: "SolarStations",
                keyColumn: "Id",
                keyValue: new Guid("5de324e0-203d-4478-8fb2-e19d686500eb"));

            migrationBuilder.DeleteData(
                table: "SolarStations",
                keyColumn: "Id",
                keyValue: new Guid("c8e840fc-f108-4a75-bff6-099d7f979bd0"));

            migrationBuilder.DeleteData(
                table: "SolarStations",
                keyColumn: "Id",
                keyValue: new Guid("d5db0978-13b6-4ba6-a20a-777de3d9b660"));

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
    }
}
