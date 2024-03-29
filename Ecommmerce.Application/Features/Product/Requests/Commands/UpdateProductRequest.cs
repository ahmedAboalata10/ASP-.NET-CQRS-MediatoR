using Ecommmerce.Application.DTO.Entities.Product;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommmerce.Application.Features.Product.Requests.Commands
{
    public class UpdateProductRequest : IRequest<Unit>
    {
        public ProductDTO ProductDTO { get; set; }
    }
}
