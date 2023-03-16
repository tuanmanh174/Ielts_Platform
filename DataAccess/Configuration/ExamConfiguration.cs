using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Configuration
{
    public class ExamConfiguration : IEntityTypeConfiguration<Exam>
    {
        public void Configure(EntityTypeBuilder<Exam> builder)
        {
            builder.ToTable("Exams");
            builder.HasKey(x => x.EXAM_ID);
            builder.Property(x => x.EXAM_ID).UseIdentityColumn();
            builder.Property(x => x.EXAM_CODE).IsRequired();
            builder.Property(x => x.EXAM_NAME).IsRequired();
            builder.Property(x => x.SCHOOL_ID).IsRequired();
        }
    }
}
