using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class updateDBExamAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Exams",
                newName: "STATUS");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Exams",
                newName: "DESCRIPTION");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e97e62f2-e790-46a0-b0f4-b070052544f7"),
                column: "ConcurrencyStamp",
                value: "a2b73ba1-6b32-4020-befe-ed0c6be091d0");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d519fa35-0c44-49cc-b9a7-17b9a2364e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b18dd823-ec84-49af-a80f-fa51efa12b53", "AQAAAAEAACcQAAAAEBgpNWcoYgcelxk1FEEbn9X3+erHLfvJxjdxYe4l1goFId7PiNphkk+m8KmaQily9g==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "STATUS",
                table: "Exams",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "DESCRIPTION",
                table: "Exams",
                newName: "Description");

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
    }
}
