using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class updateDBExam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Exams",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "START_DATE",
                table: "Exams",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Exams",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e97e62f2-e790-46a0-b0f4-b070052544f7"),
                column: "ConcurrencyStamp",
                value: "877ea6a7-f300-4934-9dec-2abe96bf8ded");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d519fa35-0c44-49cc-b9a7-17b9a2364e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dc73fbcf-c72d-4d98-9ed1-53904e22f218", "AQAAAAEAACcQAAAAEOy0p8YuRbaQUx/IAnhG35QH8za+/nThNVWtmOZnbN7Li6Y2qm5iS1hVw5pl4SuA1g==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "START_DATE",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Exams");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e97e62f2-e790-46a0-b0f4-b070052544f7"),
                column: "ConcurrencyStamp",
                value: "efbd9d0d-9d22-4ac7-a59a-3d8a2a7bcafc");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d519fa35-0c44-49cc-b9a7-17b9a2364e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "88223f21-11bc-411b-9265-1acda1ef8adf", "AQAAAAEAACcQAAAAEGjbb2suNhCoESf9ys3+EQECiHd78j3CT6tFNejs2S1/9dUlBhAswO0pELf9XDdJiQ==" });
        }
    }
}
