using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Configuration
{
    public class PartConfiguration : IEntityTypeConfiguration<Part>
    {
        public void Configure(EntityTypeBuilder<Part> builder)
        {
            builder.ToTable("Parts");
            builder.HasKey(x => x.PART_ID);
            builder.Property(x => x.PART_ID).UseIdentityColumn();
            builder.Property(x => x.FROM_NUMBER).IsRequired();
            builder.Property(x => x.TO_NUMBER).IsRequired();
            builder.Property(x => x.PART_CONTENT).IsRequired();
            builder.Property(x => x.TEST_ID).IsRequired();
        }
    }
}
