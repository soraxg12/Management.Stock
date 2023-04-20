using Management.Socket.Domain.Entities;
using Management.Stock.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Management.Stock.Infra.Data.Context
{
    public class ManagementContext : DbContext
    {
        public ManagementContext()
        {
        }

        public ManagementContext(DbContextOptions<ManagementContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        string dbc = "Server=localhost,1433;Database=management;User Id=clientecte;Password=teste123;";

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //  => options.UseSqlite("Data Source=ManagementStock.db");
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
          => options.UseSqlServer(dbc);

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Product>(new ProductMap().Configure);
            builder.Entity<Category>(new CategoryMap().Configure);
            builder.Entity<Brand>(new BrandMap().Configure);
        }
    }
}
