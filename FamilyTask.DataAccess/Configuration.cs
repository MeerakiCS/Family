using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;


namespace FamilyTask.DataAccess
{
    internal sealed class Configuration : IDesignTimeDbContextFactory<ApplicationDbContext>
    {

        private IConfiguration config => new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
       .AddJsonFile("appsettings.json")
       .Build();

        public ApplicationDbContext CreateDbContext(string[] args)
        {
            

            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            builder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            return new ApplicationDbContext(builder.Options);
        }
    }
}
