using Management.Socket.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Management.Stock.Infra.Data.Mapping
{
   public class ProductMap : IEntityTypeConfiguration<Product>
   {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Description)
               .HasConversion(prop => prop.ToString(), prop => prop)
               .IsRequired()
               .HasColumnName("Description")
               .HasColumnType("varchar(100)");

            builder.Property(prop => prop.CategoryId)
               .IsRequired()
               .HasColumnName("CategoryId");
        }
   }
}
