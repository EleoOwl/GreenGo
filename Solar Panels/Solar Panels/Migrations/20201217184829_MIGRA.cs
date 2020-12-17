using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GreenGo.DB.API.Migrations
{
    public partial class MIGRA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SolarStations",
                keyColumn: "Id",
                keyValue: new Guid("f0449048-6210-4c37-aa97-60e61610ef1b"));

            migrationBuilder.InsertData(
                table: "SolarStations",
                column: "Id",
                value: new Guid("f876a7a6-40bb-4437-a7b4-4d530b383c78"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SolarStations",
                keyColumn: "Id",
                keyValue: new Guid("f876a7a6-40bb-4437-a7b4-4d530b383c78"));

            migrationBuilder.InsertData(
                table: "SolarStations",
                column: "Id",
                value: new Guid("f0449048-6210-4c37-aa97-60e61610ef1b"));
        }
    }
}
