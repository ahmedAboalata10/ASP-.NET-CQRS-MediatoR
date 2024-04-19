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
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category(1, "Category One", "Description One"),
                new Category(2, "Category Two", "Description Two"),
                new Category(3, "Category Three", "Description Three"),
                new Category(4, "Category Four", "Description Four"),
                new Category(5, "Category five", "Description five")
                );
        }
    }
}
