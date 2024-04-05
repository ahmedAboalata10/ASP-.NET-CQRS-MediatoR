
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommmerce.Application.Persistance.Contracts;

public interface IProductRepository:IGenericRepository<Product>
{
    Task<List<Product>> GetAllProductsWithInclude();
}
