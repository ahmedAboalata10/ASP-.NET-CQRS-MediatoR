using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommmerce.Application.Features.Categories.Requests.Commands
{
    public class DeleteCategoryReuest:IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
