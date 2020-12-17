using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GreenGo.DB.API.Migrations
{
    public partial class Revives : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Inverters",
                keyColumn: "Id",
                keyValue: new Guid("7dcf1e76-6bd6-4fb7-8647-91f5497ac233"));

            migrationBuilder.DeleteData(
                table: "Inverters",
                keyColumn: "Id",
                keyValue: new Guid("eeb5c5f4-7a88-481f-81eb-2e62abe83b96"));

            migrationBuilder.DeleteData(
                table: "ReferenceTables",
                keyColumn: "Id",
                keyValue: new Guid("26a2242a-659d-4158-ac39-fdbd29c576e2"));

            migrationBuilder.DeleteData(
                table: "SolarStations",
                keyColumn: "Id",
                keyValue: new Guid("17046f99-fdb3-437b-ae20-cc39dd7ee12e"));

            migrationBuilder.InsertData(
                table: "Inverters",
                columns: new[] { "Id", "Company", "Power", "Price" },
                values: new object[,]
                {
                    { new Guid("5acd3baf-4d4e-4cfe-8450-e5638d211ab9"), null, 0.0, 0.0 },
                    { new Guid("4f3e3588-db78-4c65-b3b4-75d33dbb9205"), null, 0.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "ReferenceTables",
                columns: new[] { "Id", "IdInverter", "IdStation" },
                values: new object[] { new Guid("f4e832fe-5d7b-47e1-be35-fd4178172a19"), new Guid("32fb5677-bda8-47a2-a29c-2a0220cd3eda"), new Guid("04f942e4-ff81-4f24-af35-58f77c0fd2c6") });

            migrationBuilder.InsertData(
                table: "SolarStations",
                column: "Id",
                value: new Guid("85ec08dc-6245-44ef-9ce7-9829596ef939"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Inverters",
                keyColumn: "Id",
                keyValue: new Guid("4f3e3588-db78-4c65-b3b4-75d33dbb9205"));

            migrationBuilder.DeleteData(
                table: "Inverters",
                keyColumn: "Id",
                keyValue: new Guid("5acd3baf-4d4e-4cfe-8450-e5638d211ab9"));

            migrationBuilder.DeleteData(
                table: "ReferenceTables",
                keyColumn: "Id",
                keyValue: new Guid("f4e832fe-5d7b-47e1-be35-fd4178172a19"));

            migrationBuilder.DeleteData(
                table: "SolarStations",
                keyColumn: "Id",
                keyValue: new Guid("85ec08dc-6245-44ef-9ce7-9829596ef939"));

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
    }
}
