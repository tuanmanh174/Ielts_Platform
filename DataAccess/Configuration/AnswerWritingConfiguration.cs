using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Configuration
{
    public class AnswerWritingConfiguration : IEntityTypeConfiguration<AnswerWriting>
    {
        public void Configure(EntityTypeBuilder<AnswerWriting> builder)
        {
            builder.ToTable("AnswerWritings");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.StudentId).IsRequired();
        }
    }
}
