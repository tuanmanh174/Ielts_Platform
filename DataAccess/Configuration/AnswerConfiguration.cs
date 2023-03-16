using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Configuration
{
    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.ToTable("Answers");
            builder.HasKey(x => x.ANSWER_ID);
            builder.Property(x => x.ANSWER_ID).UseIdentityColumn();
            builder.Property(x => x.QUESTION_ID).IsRequired();
        }
    }
}
