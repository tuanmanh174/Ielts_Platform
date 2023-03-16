using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class updateDBQuestion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LELVEL",
                table: "Questions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e97e62f2-e790-46a0-b0f4-b070052544f7"),
                column: "ConcurrencyStamp",
                value: "683fcae0-31bf-436a-b783-6c3363730ac1");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d519fa35-0c44-49cc-b9a7-17b9a2364e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "470bba45-4cf9-42a7-8657-57739cc086db", "AQAAAAEAACcQAAAAEOjioI+PfZUWrWB5vbQ+EAxdGa2xld26DX5wVUvkyUQZg3TNPwmH7Wdl/P2vcB8/zA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LELVEL",
                table: "Questions");

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
    }
}
