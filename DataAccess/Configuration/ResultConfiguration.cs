using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Configuration
{
    public class ResultConfiguration : IEntityTypeConfiguration<Result>
    {
        public void Configure(EntityTypeBuilder<Result> builder)
        {
            builder.ToTable("Results");
            builder.HasKey(x => x.RESULT_ID);
            builder.Property(x => x.RESULT_ID).UseIdentityColumn();
            builder.Property(x => x.QUESTION_ID).IsRequired();
            builder.Property(x => x.MARK).IsRequired();
            builder.Property(x => x.EXAM_ID).IsRequired();
            builder.Property(x => x.ANSWER_TRUE).IsRequired();
            builder.Property(x => x.ANSWER).IsRequired();
        }
    }
}
