using Ecommmerce.Application.DTO.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommmerce.Application.DTO.Entities
{
    public class ProductDTO:BaseEntityDTO<int>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}   
