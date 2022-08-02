using CQRS.Infrastructure.Model;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace CQRS.Infrastructure.Context
{
    public class PsqlContext : DbContext
    {
        protected readonly IConfiguration configuration;
        
        public PsqlContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(configuration.GetConnectionString("PostgresqlConnectionString"));       
        }

        public DbSet<Product> Products { get; set; }
    }
}
