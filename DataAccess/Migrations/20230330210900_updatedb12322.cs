using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class updatedb12322 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e97e62f2-e790-46a0-b0f4-b070052544f7"),
                column: "ConcurrencyStamp",
                value: "d4e9e948-fa1d-4f5c-a3db-b9ad27221e7d");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d519fa35-0c44-49cc-b9a7-17b9a2364e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b995ddb7-92f3-4f53-87ec-d156245f3fc0", "AQAAAAEAACcQAAAAEB5BBBYz710+QuyoTUrxBgyexemQ7+LIlQI6LakJBZ7X2Ze2vqm0uamCZQhUvEtf/Q==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
