using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    ANSWER_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QUESTION_ID = table.Column<int>(nullable: false),
                    ANSWER_CONTENT = table.Column<string>(nullable: true),
                    ANSWER_TRUE = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.ANSWER_ID);
                });

            migrationBuilder.CreateTable(
                name: "AppConfigs",
                columns: table => new
                {
                    Key = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppConfigs", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CITY_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CREATED_DATE = table.Column<DateTime>(nullable: true),
                    CREATED_BY = table.Column<string>(nullable: true),
                    UPDATED_DATE = table.Column<DateTime>(nullable: true),
                    UPDATED_BY = table.Column<string>(nullable: true),
                    CITY_CODE = table.Column<string>(nullable: false),
                    CITY_NAME = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CITY_ID);
                });

            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    EXAM_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CREATED_DATE = table.Column<DateTime>(nullable: true),
                    CREATED_BY = table.Column<string>(nullable: true),
                    UPDATED_DATE = table.Column<DateTime>(nullable: true),
                    UPDATED_BY = table.Column<string>(nullable: true),
                    EXAM_CODE = table.Column<string>(nullable: false),
                    EXAM_NAME = table.Column<string>(nullable: false),
                    SCHOOL_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.EXAM_ID);
                });

            migrationBuilder.CreateTable(
                name: "ExamStudents",
                columns: table => new
                {
                    EXAM_ID = table.Column<int>(nullable: false),
                    STUDENT_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ExamTest",
                columns: table => new
                {
                    EXAM_ID = table.Column<int>(nullable: false),
                    TEST_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Parts",
                columns: table => new
                {
                    PART_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CREATED_DATE = table.Column<DateTime>(nullable: true),
                    CREATED_BY = table.Column<string>(nullable: true),
                    UPDATED_DATE = table.Column<DateTime>(nullable: true),
                    UPDATED_BY = table.Column<string>(nullable: true),
                    PART_CONTENT = table.Column<string>(nullable: false),
                    FROM_NUMBER = table.Column<int>(nullable: false),
                    TO_NUMBER = table.Column<int>(nullable: false),
                    TEST_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parts", x => x.PART_ID);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QUESTION_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CREATED_DATE = table.Column<DateTime>(nullable: true),
                    CREATED_BY = table.Column<string>(nullable: true),
                    UPDATED_DATE = table.Column<DateTime>(nullable: true),
                    UPDATED_BY = table.Column<string>(nullable: true),
                    QUESTION_TYPE = table.Column<int>(nullable: false),
                    QUESTION_CONTENT = table.Column<string>(nullable: false),
                    PART_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QUESTION_ID);
                });

            migrationBuilder.CreateTable(
                name: "QuestionTests",
                columns: table => new
                {
                    TEST_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CREATED_DATE = table.Column<DateTime>(nullable: true),
                    CREATED_BY = table.Column<string>(nullable: true),
                    UPDATED_DATE = table.Column<DateTime>(nullable: true),
                    UPDATED_BY = table.Column<string>(nullable: true),
                    TEST_NAME = table.Column<string>(nullable: false),
                    SCHOOL_ID = table.Column<int>(nullable: false),
                    NUMBER_PART = table.Column<int>(nullable: false),
                    TEST_TYPE = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionTests", x => x.TEST_ID);
                });

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    RESULT_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EXAM_ID = table.Column<int>(nullable: false),
                    ANSWER = table.Column<string>(nullable: false),
                    ANSWER_TRUE = table.Column<string>(nullable: false),
                    QUESTION_ID = table.Column<int>(nullable: false),
                    MARK = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.RESULT_ID);
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    SCHOOL_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CREATED_DATE = table.Column<DateTime>(nullable: true),
                    CREATED_BY = table.Column<string>(nullable: true),
                    UPDATED_DATE = table.Column<DateTime>(nullable: true),
                    UPDATED_BY = table.Column<string>(nullable: true),
                    SCHOOL_NAME = table.Column<string>(nullable: false),
                    SCHOOL_CODE = table.Column<string>(nullable: false),
                    ADDRESS = table.Column<string>(nullable: true),
                    PHONE = table.Column<int>(nullable: true),
                    TEL = table.Column<int>(nullable: true),
                    CITY_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.SCHOOL_ID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    STUDENT_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CREATED_DATE = table.Column<DateTime>(nullable: true),
                    CREATED_BY = table.Column<string>(nullable: true),
                    UPDATED_DATE = table.Column<DateTime>(nullable: true),
                    UPDATED_BY = table.Column<string>(nullable: true),
                    STUDENT_NAME = table.Column<string>(nullable: false),
                    STUDENT_CODE = table.Column<string>(nullable: false),
                    SCHOOL_ID = table.Column<int>(nullable: true),
                    TEL = table.Column<int>(nullable: true),
                    EMAIL = table.Column<string>(nullable: true),
                    CLASS = table.Column<string>(nullable: true),
                    PASSWORD = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.STUDENT_ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    USER_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CREATED_DATE = table.Column<DateTime>(nullable: true),
                    CREATED_BY = table.Column<string>(nullable: true),
                    UPDATED_DATE = table.Column<DateTime>(nullable: true),
                    UPDATED_BY = table.Column<string>(nullable: true),
                    USER_NAME = table.Column<string>(nullable: false),
                    USER_CODE = table.Column<string>(nullable: true),
                    TEL = table.Column<int>(nullable: false),
                    EMAIL = table.Column<string>(nullable: true),
                    IMAGE = table.Column<string>(nullable: true),
                    PASSWORD = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.USER_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "AppConfigs");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "ExamStudents");

            migrationBuilder.DropTable(
                name: "ExamTest");

            migrationBuilder.DropTable(
                name: "Parts");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "QuestionTests");

            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropTable(
                name: "Schools");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
