using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommmerce.Application.Features.Product.Requests.Commands
{
    public class DeleteProductReuest : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
