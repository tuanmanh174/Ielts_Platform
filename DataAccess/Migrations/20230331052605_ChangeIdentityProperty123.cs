using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class ChangeIdentityProperty123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e97e62f2-e790-46a0-b0f4-b070052544f7"),
                column: "ConcurrencyStamp",
                value: "7962d847-b515-4d57-a937-1f48e3b19bfc");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d519fa35-0c44-49cc-b9a7-17b9a2364e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "01c69d67-f375-48c9-9184-b67f142deb11", "AQAAAAEAACcQAAAAEGXb5d4M1S+YYbpwLQcQ8JVaprWF7PcGHxXf1T24qp3qbjpmG1EL1UAea36naw3uIg==" });


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e97e62f2-e790-46a0-b0f4-b070052544f7"),
                column: "ConcurrencyStamp",
                value: "31c30b08-dd4c-4f56-897c-304d59edc98d");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d519fa35-0c44-49cc-b9a7-17b9a2364e8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "99cbd641-a01d-4501-90f0-38fb020caf1f", "AQAAAAEAACcQAAAAEApwFbOeu4Npv9ernCkgdjTYSExV3U96Z8HYre+lv0VJIkDkQHQgoOH4IX+LKNc93g==" });
        }
    }
}
