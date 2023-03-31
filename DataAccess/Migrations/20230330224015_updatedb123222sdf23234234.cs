using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class updatedb123222sdf23234234 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e97e62f2-e790-46a0-b0f4-b070052544f7"),
                column: "ConcurrencyStamp",
                value: "a350da57-a631-44cb-a8a9-dcd7e292cb37");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d519fa35-0c44-49cc-b9a7-17b9a2364e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ab4cc915-5b95-4713-8c87-2bf13461b10e", "AQAAAAEAACcQAAAAEAV1CXaKZR7pVBC8TXs6sQVdoTps6Fh4rIvUrMOveDFrhaYYCsWm7x7/7sMIeX8LEw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StudentId",
                table: "AnswerWritings",
                type: "nvarchar(max)",
                nullable: true);

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
    }
}
