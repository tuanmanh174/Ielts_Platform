using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class updatedatabaseSchool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "STATUS",
                table: "Schools",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e97e62f2-e790-46a0-b0f4-b070052544f7"),
                column: "ConcurrencyStamp",
                value: "2528c72c-54d0-4c4e-aa9d-d5ff69818fd3");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d519fa35-0c44-49cc-b9a7-17b9a2364e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c6c00ed2-3c03-492c-9617-d32a106059e3", "AQAAAAEAACcQAAAAEJpLY9Fl7eix2XZHV0hS1hsNWpNP/C867iaZlh7Qkm+x5kurBqZSVuTdDauJXtTPsQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "STATUS",
                table: "Schools");

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
    }
}
