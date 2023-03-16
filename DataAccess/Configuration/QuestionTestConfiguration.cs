using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Configuration
{
    public class QuestionTestConfiguration : IEntityTypeConfiguration<QuestionTest>
    {
        public void Configure(EntityTypeBuilder<QuestionTest> builder)
        {
            builder.ToTable("QuestionTests");
            builder.HasKey(x => x.TEST_ID);
            builder.Property(x => x.TEST_ID).UseIdentityColumn();
            builder.Property(x => x.SCHOOL_ID).IsRequired();
            builder.Property(x => x.TEST_NAME).IsRequired();
            builder.Property(x => x.TEST_TYPE).IsRequired();
            builder.Property(x => x.NUMBER_PART).IsRequired();
        }
    }
}
