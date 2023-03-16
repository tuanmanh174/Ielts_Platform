using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Configuration
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("Cities");
            builder.HasKey(x => x.CITY_ID);
            builder.Property(x => x.CITY_ID).UseIdentityColumn();
            builder.Property(x => x.CITY_CODE).IsRequired();
            builder.Property(x => x.CITY_NAME).IsRequired();
        }
    }
}
