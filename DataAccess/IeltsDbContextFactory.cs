using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataAccess
{
    public class IeltsDbContextFactory : IDesignTimeDbContextFactory<IeltsDbContext>
    {
        public IeltsDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("IeltsDatabase");
            var optionsBuilder = new DbContextOptionsBuilder<IeltsDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new IeltsDbContext(optionsBuilder.Options);
        }
    }
}
