using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Seeds
{
    class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product { Id = 1, Name = "Pencil1", CategoryId = 1, CreatedDate = DateTime.Now, UnitsInStock = 10, UnitPrice = 15 });
            builder.HasData(new Product { Id = 2, Name = "Pencil2", CategoryId = 1, CreatedDate = DateTime.Now, UnitsInStock = 12, UnitPrice = 11 });
            builder.HasData(new Product { Id = 3, Name = "Pencil3", CategoryId = 1, CreatedDate = DateTime.Now, UnitsInStock = 8, UnitPrice = 8 });
            builder.HasData(new Product { Id = 4, Name = "Computer1", CategoryId = 2, CreatedDate = DateTime.Now, UnitsInStock = 20, UnitPrice = 800 });
            builder.HasData(new Product { Id = 5, Name = "Computer2", CategoryId = 2, CreatedDate = DateTime.Now, UnitsInStock = 23, UnitPrice = 887 });
        }
    }
}
