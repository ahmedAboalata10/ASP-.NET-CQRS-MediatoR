using Ecommmerce.Application.DTO.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommmerce.Application.DTO.Entities.Category
{
    public class CategoryDTO : BaseEntityDTO<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
