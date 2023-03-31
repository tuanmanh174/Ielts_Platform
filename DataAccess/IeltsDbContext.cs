using DataAccess.Configuration;
using DataAccess.Entities;
using DataAccess.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess
{
    public class IeltsDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public IeltsDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new AnswerConfiguration());
            modelBuilder.ApplyConfiguration(new CityConfiguration());
            modelBuilder.ApplyConfiguration(new ExamConfiguration());
            modelBuilder.ApplyConfiguration(new ExamStudentConfiguration());
            modelBuilder.ApplyConfiguration(new ExamTestConfiguration());
            modelBuilder.ApplyConfiguration(new PartConfiguration());
            modelBuilder.ApplyConfiguration(new QuestionConfiguration());
            modelBuilder.ApplyConfiguration(new QuestionTestConfiguration());
            modelBuilder.ApplyConfiguration(new ResultConfiguration());
            modelBuilder.ApplyConfiguration(new SchoolConfiguration());

            modelBuilder.ApplyConfiguration(new QuestionPartConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppStudentClaims");
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppStudentLogin").HasKey(x => x.UserId);
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppStudentTokens").HasKey(x => x.UserId);

            modelBuilder.Seed();
        }

        public DbSet<Answer> Answers { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<ExamStudent> ExamStudents { get; set; }
        public DbSet<ExamTest> ExamTests { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionTest> QuestionTests { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<QuestionPart> QuestionParts { get; set; }



        public DbSet<Writing> Writings { get; set; }
        public DbSet<AnswerWriting> AnswerWritings { get; set; }
    }
}
