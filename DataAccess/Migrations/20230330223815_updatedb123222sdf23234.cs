using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class updatedb123222sdf23234 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e97e62f2-e790-46a0-b0f4-b070052544f7"),
                column: "ConcurrencyStamp",
                value: "cb9236d2-b647-409e-99f5-0467affe9884");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d519fa35-0c44-49cc-b9a7-17b9a2364e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cca491e1-1432-4b1b-af21-1455f5841752", "AQAAAAEAACcQAAAAEKTUrEM2ambWjmCPeZOI4+LbO8Kecda/AngHv5OftCRhI01tXkqkSZE3nTL4aSPCjA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e97e62f2-e790-46a0-b0f4-b070052544f7"),
                column: "ConcurrencyStamp",
                value: "62ac0605-6ea1-4ccd-a65f-fdb59a8487e9");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d519fa35-0c44-49cc-b9a7-17b9a2364e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5460a0df-b3a0-49e4-a03c-d8938b664a15", "AQAAAAEAACcQAAAAEDV/90gDeXRElh+ucWyPhaDu1MW1HO680W+79AQGE3ctKHMg4Jx0J6VyrPuAyQ37Vg==" });
        }
    }
}
