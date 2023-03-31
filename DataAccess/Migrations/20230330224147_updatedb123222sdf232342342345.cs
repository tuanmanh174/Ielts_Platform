using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class updatedb123222sdf232342342345 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e97e62f2-e790-46a0-b0f4-b070052544f7"),
                column: "ConcurrencyStamp",
                value: "dbf6ada7-e13e-4e65-8910-0ff6efda780b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d519fa35-0c44-49cc-b9a7-17b9a2364e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b16f8d01-0fd1-497a-9e50-eaef142a95f5", "AQAAAAEAACcQAAAAEKvNHyPRuvvnzXROcIqfXygrOQr9mz5AlNlqI9mwonhf7DXJ50FeatcyJfYzjGzVhg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "AnswerWritings");

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
    }
}
