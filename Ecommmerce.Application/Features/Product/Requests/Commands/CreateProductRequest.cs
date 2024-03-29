using Ecommmerce.Application.DTO.Entities.Product;
using Ecommmerce.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommmerce.Application.Features.Product.Requests.Commands
{
    public class CreateProductRequest : IRequest<BaseCommandResponse>
    {
        public ProductDTO ProductDTO { get; set; }
    }
}
