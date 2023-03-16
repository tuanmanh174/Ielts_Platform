using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppConfigs",
                columns: new[] { "Key", "Value" },
                values: new object[,]
                {
                    { "HomeTitle", "This is home page of Ielts" },
                    { "HomeKeyword", "This is keyword of Ielts" },
                    { "HomeDescription", "This is description of Ielts" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "USER_ID", "CREATED_BY", "CREATED_DATE", "EMAIL", "IMAGE", "PASSWORD", "TEL", "UPDATED_BY", "UPDATED_DATE", "USER_CODE", "USER_NAME" },
                values: new object[] { 1, null, null, "tuanmanh17@gmail.com", null, "123456", 986882026, null, null, "manhdt", "Đặng Tuấn Mạnh" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeDescription");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeKeyword");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeTitle");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "USER_ID",
                keyValue: 1);
        }
    }
}
