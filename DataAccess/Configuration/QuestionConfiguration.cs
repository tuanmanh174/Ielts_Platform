using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Configuration
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.ToTable("Questions");
            builder.HasKey(x => x.QUESTION_ID);
            builder.Property(x => x.QUESTION_ID).UseIdentityColumn();
            builder.Property(x => x.QUESTION_TYPE).IsRequired();
            builder.Property(x => x.QUESTION_CONTENT).IsRequired();
        }
    }
}
