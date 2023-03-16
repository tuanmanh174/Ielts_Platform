using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class updateDbAppUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SchoolId",
                table: "AppUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e97e62f2-e790-46a0-b0f4-b070052544f7"),
                column: "ConcurrencyStamp",
                value: "cb5e8175-8c02-47a7-8867-a8518fb8cf0e");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d519fa35-0c44-49cc-b9a7-17b9a2364e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6d1c0f3b-53ba-4ca7-8390-1bce17ce5490", "AQAAAAEAACcQAAAAECNUl0FTrJ8ljsXJHkdLrAWfF0yQl+ZIPmGfVar/adZXG9OWHHSjAKWpZhaWfdlSZA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SchoolId",
                table: "AppUsers");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e97e62f2-e790-46a0-b0f4-b070052544f7"),
                column: "ConcurrencyStamp",
                value: "683fcae0-31bf-436a-b783-6c3363730ac1");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d519fa35-0c44-49cc-b9a7-17b9a2364e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "470bba45-4cf9-42a7-8657-57739cc086db", "AQAAAAEAACcQAAAAEOjioI+PfZUWrWB5vbQ+EAxdGa2xld26DX5wVUvkyUQZg3TNPwmH7Wdl/P2vcB8/zA==" });
        }
    }
}
