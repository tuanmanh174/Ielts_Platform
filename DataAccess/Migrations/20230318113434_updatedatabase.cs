using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class updatedatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PART_ID",
                table: "Questions");

            migrationBuilder.CreateTable(
                name: "QuestionParts",
                columns: table => new
                {
                    QUESTION_ID = table.Column<int>(nullable: false),
                    PART_ID = table.Column<int>(nullable: false),
                    TEST_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e97e62f2-e790-46a0-b0f4-b070052544f7"),
                column: "ConcurrencyStamp",
                value: "969eceed-7bb1-43d2-80c2-2731520cfe4d");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d519fa35-0c44-49cc-b9a7-17b9a2364e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fc39c88f-b53c-4df2-8b59-a6dddf394ade", "AQAAAAEAACcQAAAAEIq/uXG/CoXmRiO8HsZ5NbRnrxLallwMDiudeC0TG6+qcCuuNKUZgZ2cDwWh7SrdzA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionParts");

            migrationBuilder.AddColumn<int>(
                name: "PART_ID",
                table: "Questions",
                type: "int",
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
    }
}
