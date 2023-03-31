using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Configuration
{
    public class WritingConfiguration : IEntityTypeConfiguration<Writing>
    {
        public void Configure(EntityTypeBuilder<Writing> builder)
        {
            builder.ToTable("Writings");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Title1).IsRequired();
            builder.Property(x => x.Title1).IsRequired();
        }
    }
}
