using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Configuration
{
    public class ExamTestConfiguration : IEntityTypeConfiguration<ExamTest>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ExamTest> builder)
        {
            builder.ToTable("ExamTest");
            builder.HasNoKey();
            builder.Property(x => x.EXAM_ID).IsRequired();
            builder.Property(x => x.TEST_ID).IsRequired();
        }
    }
}
