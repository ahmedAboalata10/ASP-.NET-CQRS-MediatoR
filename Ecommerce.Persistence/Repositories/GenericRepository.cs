using Ecommerce.Persistence.DataBaseContext;
using Ecommmerce.Application.Persistance.Contracts;
using Microsoft.EntityFrameworkCore;


namespace Ecommerce.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDBContext context;

        public GenericRepository(ApplicationDBContext context)
        {
            this.context=context;
        }
        public async Task CreateAsync(T entity)
        {
            await context.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            if(GetAsync(id) != null)
            {
                context.Set<T>().Remove(await GetAsync(id));  
            }
            await context.SaveChangesAsync();
        }

        public async Task<bool> ExistAsync(int id)
        {
            var entry =await  GetAsync(id);
            return entry != null;
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
           return await context.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> GetAsync(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(int id, T entity)
        {
           context.Entry(entity).State=EntityState.Modified;
            await context.SaveChangesAsync();
        }
    }
}
