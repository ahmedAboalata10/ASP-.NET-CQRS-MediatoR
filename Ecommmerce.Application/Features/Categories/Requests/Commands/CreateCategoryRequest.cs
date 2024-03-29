using Ecommmerce.Application.DTO.Entities.Category;
using Ecommmerce.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommmerce.Application.Features.Categories.Requests.Commands
{
    public class CreateCategoryRequest:IRequest<BaseCommandResponse>
    {
        public CategoryDTO CategoryDTO { get; set; }
    }
}
