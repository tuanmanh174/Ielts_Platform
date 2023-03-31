using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class ChangeIdentityProperty3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e97e62f2-e790-46a0-b0f4-b070052544f7"),
                column: "ConcurrencyStamp",
                value: "31c30b08-dd4c-4f56-897c-304d59edc98d");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d519fa35-0c44-49cc-b9a7-17b9a2364e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "99cbd641-a01d-4501-90f0-38fb020caf1f", "AQAAAAEAACcQAAAAEApwFbOeu4Npv9ernCkgdjTYSExV3U96Z8HYre+lv0VJIkDkQHQgoOH4IX+LKNc93g==" });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e97e62f2-e790-46a0-b0f4-b070052544f7"),
                column: "ConcurrencyStamp",
                value: "db92961b-6d4f-46e3-88b6-003c3eddbab3");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d519fa35-0c44-49cc-b9a7-17b9a2364e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "281045f9-908a-4fe7-9621-c3e794168ab7", "AQAAAAEAACcQAAAAEEle9h5AdiEHs5YwO4+HoF4SAqUlDcNIfronAEn3+OgQwsgGt1FjQeadf35PXLRsaA==" });
        }
    }
}
