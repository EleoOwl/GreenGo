using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GreenGo.DB.API.Migrations
{
    public partial class Renasance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
