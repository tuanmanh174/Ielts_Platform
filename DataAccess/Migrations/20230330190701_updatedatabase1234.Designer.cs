﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(IeltsDbContext))]
    [Migration("20230330190701_updatedatabase1234")]
    partial class updatedatabase1234
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataAccess.Entities.Answer", b =>
                {
                    b.Property<int>("ANSWER_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ANSWER_CONTENT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("ANSWER_TRUE")
                        .HasColumnType("bit");

                    b.Property<int>("QUESTION_ID")
                        .HasColumnType("int");

                    b.HasKey("ANSWER_ID");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("DataAccess.Entities.AppConfig", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Key");

                    b.ToTable("AppConfigs");

                    b.HasData(
                        new
                        {
                            Key = "HomeTitle",
                            Value = "This is home page of Ielts"
                        },
                        new
                        {
                            Key = "HomeKeyword",
                            Value = "This is keyword of Ielts"
                        },
                        new
                        {
                            Key = "HomeDescription",
                            Value = "This is description of Ielts"
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppRoles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e97e62f2-e790-46a0-b0f4-b070052544f7"),
                            ConcurrencyStamp = "5e2d3717-1c92-422a-a5ee-e8581f0279e0",
                            Description = "Administrator Role",
                            Name = "admin",
                            NormalizedName = "admin"
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("SchoolId")
                        .HasColumnType("int");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppUsers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d519fa35-0c44-49cc-b9a7-17b9a2364e8e"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8d04f712-7518-4411-ac34-9d0ba1ee238e",
                            Dob = new DateTime(1990, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin.ielts@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Manh",
                            LastName = "Dang Tuan",
                            LockoutEnabled = false,
                            NormalizedEmail = "admin.ielts@gmail.com",
                            NormalizedUserName = "admin",
                            PasswordHash = "AQAAAAEAACcQAAAAEPCwZiLgS9tkUqt3oge2niPwoFbM+ZJEAyOICiq5fYceE0VcPEk/0a8TSmep8GMZPA==",
                            PhoneNumberConfirmed = false,
                            SchoolId = 0,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.City", b =>
                {
                    b.Property<int>("CITY_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CITY_CODE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CITY_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CREATED_BY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CREATED_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("UPDATED_BY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UPDATED_DATE")
                        .HasColumnType("datetime2");

                    b.HasKey("CITY_ID");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("DataAccess.Entities.Exam", b =>
                {
                    b.Property<int>("EXAM_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CREATED_BY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CREATED_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("DESCRIPTION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EXAM_CODE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EXAM_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SCHOOL_ID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime>("START_DATE")
                        .HasColumnType("datetime2");

                    b.Property<bool>("STATUS")
                        .HasColumnType("bit");

                    b.Property<string>("UPDATED_BY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UPDATED_DATE")
                        .HasColumnType("datetime2");

                    b.HasKey("EXAM_ID");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("DataAccess.Entities.ExamStudent", b =>
                {
                    b.Property<int?>("EXAM_ID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("STUDENT_ID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.ToTable("ExamStudents");
                });

            modelBuilder.Entity("DataAccess.Entities.ExamTest", b =>
                {
                    b.Property<int?>("EXAM_ID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("TEST_ID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.ToTable("ExamTest");
                });

            modelBuilder.Entity("DataAccess.Entities.Part", b =>
                {
                    b.Property<int>("PART_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CREATED_BY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CREATED_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FROM_NUMBER")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("PART_CONTENT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TEST_ID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("TO_NUMBER")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("UPDATED_BY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UPDATED_DATE")
                        .HasColumnType("datetime2");

                    b.HasKey("PART_ID");

                    b.ToTable("Parts");
                });

            modelBuilder.Entity("DataAccess.Entities.Question", b =>
                {
                    b.Property<int>("QUESTION_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CREATED_BY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CREATED_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int>("LELVEL")
                        .HasColumnType("int");

                    b.Property<string>("QUESTION_CONTENT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QUESTION_TYPE")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("SCHOOL_ID")
                        .HasColumnType("int");

                    b.Property<string>("UPDATED_BY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UPDATED_DATE")
                        .HasColumnType("datetime2");

                    b.HasKey("QUESTION_ID");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("DataAccess.Entities.QuestionPart", b =>
                {
                    b.Property<int>("PART_ID")
                        .HasColumnType("int");

                    b.Property<int>("QUESTION_ID")
                        .HasColumnType("int");

                    b.ToTable("QuestionParts");
                });

            modelBuilder.Entity("DataAccess.Entities.QuestionTest", b =>
                {
                    b.Property<int>("TEST_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CREATED_BY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CREATED_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int>("NUMBER_PART")
                        .HasColumnType("int");

                    b.Property<int>("SCHOOL_ID")
                        .HasColumnType("int");

                    b.Property<string>("TEST_CODE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TEST_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TEST_TYPE")
                        .HasColumnType("int");

                    b.Property<string>("UPDATED_BY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UPDATED_DATE")
                        .HasColumnType("datetime2");

                    b.HasKey("TEST_ID");

                    b.ToTable("QuestionTests");
                });

            modelBuilder.Entity("DataAccess.Entities.Result", b =>
                {
                    b.Property<int>("RESULT_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ANSWER")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ANSWER_TRUE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EXAM_ID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("MARK")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("QUESTION_ID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("RESULT_ID");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("DataAccess.Entities.School", b =>
                {
                    b.Property<int>("SCHOOL_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ADDRESS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CITY_ID")
                        .HasColumnType("int");

                    b.Property<string>("CREATED_BY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CREATED_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PHONE")
                        .HasColumnType("int");

                    b.Property<string>("SCHOOL_CODE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SCHOOL_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("STATUS")
                        .HasColumnType("bit");

                    b.Property<int?>("TEL")
                        .HasColumnType("int");

                    b.Property<string>("UPDATED_BY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UPDATED_DATE")
                        .HasColumnType("datetime2");

                    b.HasKey("SCHOOL_ID");

                    b.ToTable("Schools");
                });

            modelBuilder.Entity("DataAccess.Entities.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("CLASS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CREATED_BY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CREATED_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FULLNAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<int?>("SCHOOL_ID")
                        .HasColumnType("int");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TEL")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("AppUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("d519fa35-0c44-49cc-b9a7-17b9a2364e8e"),
                            RoleId = new Guid("e97e62f2-e790-46a0-b0f4-b070052544f7")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserTokens");
                });
#pragma warning restore 612, 618
        }
    }
}