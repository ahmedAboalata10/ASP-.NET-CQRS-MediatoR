using Ecommmerce.Application.DTO.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommmerce.Application.Features.Categories.Requests.Commands
{
    public class UpdateCategoryRequest:IRequest<Unit>
    {
        public int Id { get; set; }
        public CategoryDTO Category { get; set; }
    }
}
