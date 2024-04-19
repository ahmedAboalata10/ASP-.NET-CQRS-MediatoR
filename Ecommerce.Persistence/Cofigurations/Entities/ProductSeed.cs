using Ecommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Persistence.Cofigurations.Entities
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product(1, "Product one","Description One", 150, 1),
                new Product(2, "Product Two","Description Two", 160, 3),
                new Product(3, "Product Three","Description Three", 180, 3),
                new Product(4, "Product Four","Description Four", 190, 2),
                new Product(5, "Product Five","Description Five", 110, 4)
                );
        }
    }
}
