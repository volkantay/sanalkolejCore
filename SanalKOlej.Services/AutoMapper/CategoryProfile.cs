using System;
using AutoMapper;
using SanalKolej.Entities.Concrate;
using SanalKolej.Entities.Dtos;

namespace SanalKolej.Services.AutoMapper
{
    public class CategoryProfile:Profile
    {
        public CategoryProfile()
        {

            CreateMap<CategoryAddDto, Category>()
                .ForMember(destinationMember => destinationMember.CreatedDate,
                opt=>opt.MapFrom(x=>DateTime.Now));

            
        }

        
    }
}
