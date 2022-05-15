using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.EntityConfigurations
{
    class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn().IsRequired();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.UnitsInStock).IsRequired();
            builder.Property(x => x.UnitPrice).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(x => x.CategoryId).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
        }
    }
}
