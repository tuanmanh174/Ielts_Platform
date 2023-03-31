using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class updatedb123222sdf2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e97e62f2-e790-46a0-b0f4-b070052544f7"),
                column: "ConcurrencyStamp",
                value: "ca284f77-5637-46f5-967a-20da4abcca2b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d519fa35-0c44-49cc-b9a7-17b9a2364e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "14c72816-aead-4e8c-aaf9-f8c4a1c2118e", "AQAAAAEAACcQAAAAEHzs4DnSxxcEpXICohfOzgLlU35dqFKHyRmvMpIP+j7baI133KGWwTPD3SybOAg5IQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e97e62f2-e790-46a0-b0f4-b070052544f7"),
                column: "ConcurrencyStamp",
                value: "e44cc2e7-c7a7-4c2a-aa04-c10877745895");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d519fa35-0c44-49cc-b9a7-17b9a2364e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a72d3b2e-7b20-4ca7-ac22-d235581335da", "AQAAAAEAACcQAAAAECg/uLSbzTh57ogg8kW4pP8EmKGpgPoKA855TFWkf9+34RFyUvHUCZadJttQElgEzQ==" });
        }
    }
}
