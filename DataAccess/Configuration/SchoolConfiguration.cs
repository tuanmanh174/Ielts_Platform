using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Configuration
{
    public class SchoolConfiguration : IEntityTypeConfiguration<School>
    {
        public void Configure(EntityTypeBuilder<School> builder)
        {
            builder.ToTable("Schools");
            builder.HasKey(x => x.SCHOOL_ID);
            builder.Property(x => x.SCHOOL_ID).UseIdentityColumn();
            builder.Property(x => x.SCHOOL_CODE).IsRequired();
            builder.Property(x => x.SCHOOL_NAME).IsRequired();
        }
    }
}
