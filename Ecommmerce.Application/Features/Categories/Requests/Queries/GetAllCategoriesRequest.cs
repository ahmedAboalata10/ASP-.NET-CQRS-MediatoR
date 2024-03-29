using Ecommmerce.Application.DTO.Entities.Category;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommmerce.Application.Features.Categories.Requests.Queries
{
    public class GetAllCategoriesRequest:IRequest<List<CategoryDTO>>
    {

    }
}
