using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using OpsPipelineAPI.Entities.Entity;
using OpsPipelineAPI.Repository.EDMX;

namespace OpsPipelineAPI
{
    public class AutoMapperProfile : Profile
    {

        public AutoMapperProfile()
        {
            
            
            //CreateMap<IEnumerable<Product>, IEnumerable<ProductEntity>>();
            CreateMap<AppUserEntity, AppUser>();
            //CreateMap<UserForRegistrationDto, User>()
            //    .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));
        }
    }
}
