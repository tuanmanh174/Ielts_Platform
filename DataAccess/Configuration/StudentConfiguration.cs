using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students");
            builder.HasKey(x => x.STUDENT_ID);
            builder.Property(x => x.STUDENT_ID).UseIdentityColumn();
            builder.Property(x => x.STUDENT_NAME).IsRequired();
            builder.Property(x => x.STUDENT_CODE).IsRequired();
        }
    }
}
