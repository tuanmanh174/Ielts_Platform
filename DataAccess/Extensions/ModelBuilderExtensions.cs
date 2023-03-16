using DataAccess.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var roleId = new Guid("E97E62F2-E790-46A0-B0F4-B070052544F7");
            var adminId = new Guid("D519FA35-0C44-49CC-B9A7-17B9A2364E8E");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator Role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "admin.ielts@gmail.com",
                NormalizedEmail = "admin.ielts@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123456"),
                SecurityStamp = string.Empty,
                FirstName = "Manh",
                LastName = "Dang Tuan",
                Dob = new DateTime(1990,04,17)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });

            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is home page of Ielts" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of Ielts" },
                new AppConfig() { Key = "HomeDescription", Value = "This is description of Ielts" }
                );


        }
    }
}
