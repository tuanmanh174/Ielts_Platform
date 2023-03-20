using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class updateTableQUestion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SCHOOL_ID",
                table: "Questions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e97e62f2-e790-46a0-b0f4-b070052544f7"),
                column: "ConcurrencyStamp",
                value: "9c9fd066-0eb8-4952-bc12-d9a92e53c6bb");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d519fa35-0c44-49cc-b9a7-17b9a2364e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e02171f0-c85a-4afe-9ccb-05574afc6be1", "AQAAAAEAACcQAAAAEAoq39HkuTSwt5O1LJ/u8qK6yRQFHZwieIR32+W5P/HyeLfT51dUsrxLgApWfkxGOQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SCHOOL_ID",
                table: "Questions");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e97e62f2-e790-46a0-b0f4-b070052544f7"),
                column: "ConcurrencyStamp",
                value: "5c7c8770-ae32-4765-8e19-8c07bfa44aad");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d519fa35-0c44-49cc-b9a7-17b9a2364e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5fe46469-0eb6-4a04-a67c-5d641c970380", "AQAAAAEAACcQAAAAEISKXEfP4JRAkGWtTNeE7t50sDnGx9EfjMN0OvM9zentn43kmiic2YEuBX88UI2Xvw==" });
        }
    }
}
