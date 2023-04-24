using Dev.Fluent.Data.EntityTypeConfiguration;
using Dev.Fluent.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Dev.Fluent.Data.Context
{
    public class FluentApiDbContext : DbContext
    {
        public FluentApiDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerTypeConfiguration());
        }
    }
}
