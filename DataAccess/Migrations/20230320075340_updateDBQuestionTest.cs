using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class updateDBQuestionTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TEST_CODE",
                table: "QuestionTests",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TEST_CODE",
                table: "QuestionTests");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e97e62f2-e790-46a0-b0f4-b070052544f7"),
                column: "ConcurrencyStamp",
                value: "453ffcd0-455c-4cdc-a879-bf2ac8ba1ab9");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d519fa35-0c44-49cc-b9a7-17b9a2364e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6c56b205-4bb0-4972-8841-0ab4aac3003d", "AQAAAAEAACcQAAAAEL9NfrQmZdrh0hFQGUWhNEQUwwb84iYVglsfI7Laj2xCoNSoSPAmROsZes8sUlu5yg==" });
        }
    }
}
