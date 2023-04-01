using Management.Socket.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Management.Stock.Infra.Data.Context
{
    public class ManagementContext : DbContext
    {
        //public ManagementContext(DbContextOptions<ManagementContext> options) : base(options)
        //{
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=ManagementStock.db");


        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
