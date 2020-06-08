using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AV_P.Data.EF
{
    public class AvpDbContextFactory : IDesignTimeDbContextFactory<AvpDbContext>
    {
        public AvpDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("eShopSolutionDb");

            var optionsBuilder = new DbContextOptionsBuilder<AvpDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new AvpDbContext(optionsBuilder.Options);
        }
    }
}
