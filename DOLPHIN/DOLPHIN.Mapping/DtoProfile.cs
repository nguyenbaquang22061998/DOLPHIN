using AutoMapper;
using DOLPHIN.DTO;
using DOLPHIN.Model;
using System;

namespace DOLPHIN.Mapping
{
    public class DtoProfile : Profile
    {
        public DtoProfile()
        {
            this.CreateMap<Categories, CategoriesDto>();
            this.CreateMap<CategoriesDto, Categories>();
        }
    }
}
