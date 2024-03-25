using AutoMapper;
using Ecommerce.Domain.Entities;
using Ecommmerce.Application.DTO.Entities;

namespace Ecommmerce.Application.MappingProfiles
{
    public class CategoryMappingProfile : Profile
    {
        public CategoryMappingProfile()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
        }
    }
}
