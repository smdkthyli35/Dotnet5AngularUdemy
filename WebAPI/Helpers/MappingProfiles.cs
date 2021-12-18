using AutoMapper;
using Entities.Concrete;
using Entities.Concrete.Identity;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductDetailDto>()
                    .ForMember(x => x.ProductBrandName, o => o.MapFrom(s => s.ProductBrand.Name))
                    .ForMember(x => x.ProductTypeName, o => o.MapFrom(s => s.ProductType.Name));

            CreateMap<Address, AddressDto>().ReverseMap();
        }
    }
}
