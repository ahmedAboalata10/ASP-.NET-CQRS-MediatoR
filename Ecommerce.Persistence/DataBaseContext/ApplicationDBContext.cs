using Ecommerce.Domain.Commom;
using Ecommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Persistence.DataBaseContext
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDBContext).Assembly);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity<int>>())
            {
                if (entry.State==EntityState.Modified)
                    entry.Entity.UpdatedDate= DateTime.UtcNow;
                else if (entry.State==EntityState.Added)
                    entry.Entity.CreatedDate= DateTime.UtcNow;
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
