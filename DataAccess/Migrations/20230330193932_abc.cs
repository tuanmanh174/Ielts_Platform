using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class abc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUserTokens",
                table: "AppUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUserLogins",
                table: "AppUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUserClaims",
                table: "AppUserClaims");

            migrationBuilder.RenameTable(
                name: "AppUserTokens",
                newName: "AppStudentTokens");

            migrationBuilder.RenameTable(
                name: "AppUserLogins",
                newName: "AppStudentLogin");

            migrationBuilder.RenameTable(
                name: "AppUserClaims",
                newName: "AppStudentClaims");

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "Students",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppStudentTokens",
                table: "AppStudentTokens",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppStudentLogin",
                table: "AppStudentLogin",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppStudentClaims",
                table: "AppStudentClaims",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e97e62f2-e790-46a0-b0f4-b070052544f7"),
                column: "ConcurrencyStamp",
                value: "662723b7-b792-47b4-b25d-5448ccdf2c2e");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d519fa35-0c44-49cc-b9a7-17b9a2364e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "56885113-6e65-47ba-ba7f-c5304d10efd4", "AQAAAAEAACcQAAAAEAdz7POso+F0dPSZTHUz7W+acXdM3whhq5nX9OkDYo043egJpw33o2H9gvQY6rndtw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppStudentTokens",
                table: "AppStudentTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppStudentLogin",
                table: "AppStudentLogin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppStudentClaims",
                table: "AppStudentClaims");

            migrationBuilder.RenameTable(
                name: "AppStudentTokens",
                newName: "AppUserTokens");

            migrationBuilder.RenameTable(
                name: "AppStudentLogin",
                newName: "AppUserLogins");

            migrationBuilder.RenameTable(
                name: "AppStudentClaims",
                newName: "AppUserClaims");

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUserTokens",
                table: "AppUserTokens",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUserLogins",
                table: "AppUserLogins",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUserClaims",
                table: "AppUserClaims",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e97e62f2-e790-46a0-b0f4-b070052544f7"),
                column: "ConcurrencyStamp",
                value: "5e2d3717-1c92-422a-a5ee-e8581f0279e0");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d519fa35-0c44-49cc-b9a7-17b9a2364e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8d04f712-7518-4411-ac34-9d0ba1ee238e", "AQAAAAEAACcQAAAAEPCwZiLgS9tkUqt3oge2niPwoFbM+ZJEAyOICiq5fYceE0VcPEk/0a8TSmep8GMZPA==" });
        }
    }
}
