using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GreenGo.DB.API.Migrations
{
    public partial class OVER_LAST_MIGRATION_A : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Inverters",
                keyColumn: "Id",
                keyValue: new Guid("314bcebb-5583-4577-833e-7bb6a5e95ad0"));

            migrationBuilder.DeleteData(
                table: "ReferenceTables",
                keyColumn: "Id",
                keyValue: new Guid("73bec3e5-e3ba-4f43-a706-c2eefa5ec9d4"));

            migrationBuilder.InsertData(
                table: "ReferenceTables",
                columns: new[] { "Id", "IdPanel", "IdStation" },
                values: new object[] { new Guid("2112e773-d5ad-4f34-a129-2271d84f3a1d"), new Guid("2902b665-1190-4c70-9915-b9c2d7680450"), new Guid("5de324e0-203d-4478-8fb2-e19d686500eb") });

            migrationBuilder.InsertData(
                table: "WindTurbines",
                columns: new[] { "Id", "Company", "Diameter", "Matherial", "Price", "defPower", "numBlades" },
                values: new object[,]
                {
                    { new Guid("fcee8747-7253-4fd5-a89f-2d37fc4ec079"), "Wind company", 0.0, null, 100000.0, 0.0, 0 },
                    { new Guid("07681fb5-983a-440d-9384-8cf01ef41c87"), "Summer breeeze", 0.0, null, 220000.0, 0.0, 0 },
                    { new Guid("bfa2c8ac-3f83-4381-9ab0-fe8a834aab72"), "Nice barrey", 0.0, null, 1001324.0, 0.0, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReferenceTables",
                keyColumn: "Id",
                keyValue: new Guid("2112e773-d5ad-4f34-a129-2271d84f3a1d"));

            migrationBuilder.DeleteData(
                table: "WindTurbines",
                keyColumn: "Id",
                keyValue: new Guid("07681fb5-983a-440d-9384-8cf01ef41c87"));

            migrationBuilder.DeleteData(
                table: "WindTurbines",
                keyColumn: "Id",
                keyValue: new Guid("bfa2c8ac-3f83-4381-9ab0-fe8a834aab72"));

            migrationBuilder.DeleteData(
                table: "WindTurbines",
                keyColumn: "Id",
                keyValue: new Guid("fcee8747-7253-4fd5-a89f-2d37fc4ec079"));

            migrationBuilder.InsertData(
                table: "Inverters",
                columns: new[] { "Id", "Company", "Power", "Price" },
                values: new object[] { new Guid("314bcebb-5583-4577-833e-7bb6a5e95ad0"), null, 0.0, 0.0 });

            migrationBuilder.InsertData(
                table: "ReferenceTables",
                columns: new[] { "Id", "IdPanel", "IdStation" },
                values: new object[] { new Guid("73bec3e5-e3ba-4f43-a706-c2eefa5ec9d4"), new Guid("2902b665-1190-4c70-9915-b9c2d7680450"), new Guid("5de324e0-203d-4478-8fb2-e19d686500eb") });
        }
    }
}
