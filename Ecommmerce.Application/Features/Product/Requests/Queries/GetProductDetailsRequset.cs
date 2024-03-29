using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommmerce.Application.DTO.Entities.Product;

namespace Ecommmerce.Application.Features.Product.Requests.Queries
{
    public  class GetProductDetailsRequset:IRequest<ProductDTO>
    {
        public int Id { get; set; }
    }
}
