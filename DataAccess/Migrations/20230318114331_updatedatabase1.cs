using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class updatedatabase1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TEST_ID",
                table: "QuestionParts");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e97e62f2-e790-46a0-b0f4-b070052544f7"),
                column: "ConcurrencyStamp",
                value: "453ffcd0-455c-4cdc-a879-bf2ac8ba1ab9");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d519fa35-0c44-49cc-b9a7-17b9a2364e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6c56b205-4bb0-4972-8841-0ab4aac3003d", "AQAAAAEAACcQAAAAEL9NfrQmZdrh0hFQGUWhNEQUwwb84iYVglsfI7Laj2xCoNSoSPAmROsZes8sUlu5yg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TEST_ID",
                table: "QuestionParts",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
