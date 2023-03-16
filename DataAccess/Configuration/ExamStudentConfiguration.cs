using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Configuration
{
    public class ExamStudentConfiguration : IEntityTypeConfiguration<ExamStudent>
    {
        public void Configure(EntityTypeBuilder<ExamStudent> builder)
        {
            builder.ToTable("ExamStudents");
            builder.HasNoKey();
            builder.Property(x => x.STUDENT_ID).IsRequired();
            builder.Property(x => x.EXAM_ID).IsRequired();
        }
    }
}
