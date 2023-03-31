using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class abcaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e97e62f2-e790-46a0-b0f4-b070052544f7"),
                column: "ConcurrencyStamp",
                value: "73118e28-05d0-406c-a486-ae530c558532");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d519fa35-0c44-49cc-b9a7-17b9a2364e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cd9f0d71-13fa-4ff0-b203-1b29b36b64af", "AQAAAAEAACcQAAAAEFV8nvtb1pR5iPKsfUUYLDF52BPmaMKPH0eyJ6YX2JgHFYuTSM1YEAAZLvgsXNFgBg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
