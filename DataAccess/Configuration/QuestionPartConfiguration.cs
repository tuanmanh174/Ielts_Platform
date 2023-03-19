using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Configuration
{
    public class QuestionPartConfiguration : IEntityTypeConfiguration<QuestionPart>
    {
        public void Configure(EntityTypeBuilder<QuestionPart> builder)
        {
            builder.ToTable("QuestionParts").HasNoKey();
            builder.Property(x => x.PART_ID).IsRequired();
            builder.Property(x => x.QUESTION_ID).IsRequired();
        }
    }
}
