using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class insertUserRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("e97e62f2-e790-46a0-b0f4-b070052544f7"), "efbd9d0d-9d22-4ac7-a59a-3d8a2a7bcafc", "Administrator Role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("d519fa35-0c44-49cc-b9a7-17b9a2364e8e"), new Guid("e97e62f2-e790-46a0-b0f4-b070052544f7") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("d519fa35-0c44-49cc-b9a7-17b9a2364e8e"), 0, "88223f21-11bc-411b-9265-1acda1ef8adf", new DateTime(1990, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin.ielts@gmail.com", true, "Manh", "Dang Tuan", false, null, "admin.ielts@gmail.com", "admin", "AQAAAAEAACcQAAAAEGjbb2suNhCoESf9ys3+EQECiHd78j3CT6tFNejs2S1/9dUlBhAswO0pELf9XDdJiQ==", null, false, "", false, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e97e62f2-e790-46a0-b0f4-b070052544f7"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("d519fa35-0c44-49cc-b9a7-17b9a2364e8e"), new Guid("e97e62f2-e790-46a0-b0f4-b070052544f7") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d519fa35-0c44-49cc-b9a7-17b9a2364e8e"));
        }
    }
}
