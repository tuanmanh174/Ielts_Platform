using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class droptable22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e97e62f2-e790-46a0-b0f4-b070052544f7"),
                column: "ConcurrencyStamp",
                value: "64ef12e6-85f6-4494-8bc0-8c0a0ec34271");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d519fa35-0c44-49cc-b9a7-17b9a2364e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "de966ee2-cecd-4c0e-aced-a374444e1220", "AQAAAAEAACcQAAAAEIK8u22HugXoBLMmtbfbOmO/0V18SC5+txXTXykmEUSlzLS2XyraOyYYRPWmGNZBEQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e97e62f2-e790-46a0-b0f4-b070052544f7"),
                column: "ConcurrencyStamp",
                value: "726716ee-1fcf-4d42-8f90-5d0cfaa50ad4");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d519fa35-0c44-49cc-b9a7-17b9a2364e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "739aa279-73c5-44df-b7c4-2566e7c90ae5", "AQAAAAEAACcQAAAAEJTLOiFHQ8Prt+A7UMMU+LFH8P42qBsC6PZAT42eUn5hOBvM3/TFGEyJE+ekeEH7/w==" });
        }
    }
}
