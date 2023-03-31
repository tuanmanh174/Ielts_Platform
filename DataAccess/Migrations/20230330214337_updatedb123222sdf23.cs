using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class updatedb123222sdf23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e97e62f2-e790-46a0-b0f4-b070052544f7"),
                column: "ConcurrencyStamp",
                value: "1a00e856-c493-40db-ac32-4e8719f25eb9");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d519fa35-0c44-49cc-b9a7-17b9a2364e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1bd11e73-da65-45a4-9a6f-ffb0dd99b447", "AQAAAAEAACcQAAAAEOKBm2T34QCiM8MNktmejvFqzwLCUi+ImKk6FSlV2XjdFEpdhzeDe/w+hoPvnSJO7Q==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
