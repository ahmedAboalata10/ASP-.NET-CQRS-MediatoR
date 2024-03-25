﻿using Ecommmerce.Application.DTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommmerce.Application.MappingProfiles
{
    public class ProductMappingProfile:Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<Product ,ProductDTO>().ReverseMap();
        }
    }
}
