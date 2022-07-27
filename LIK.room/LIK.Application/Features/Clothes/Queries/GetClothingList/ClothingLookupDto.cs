using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using LIK.Application.Common.Mappings;
using LIK.Domain.Models;

namespace LIK.Application.Features.Clothes.Queries.GetClothingList
{
  public class ClothingLookupDto: IMapWith<Clothing>
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int Articul { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Clothing, ClothingLookupDto>()
                    .ForMember(clothingVm => clothingVm.Id,
                                           opt => opt.MapFrom(clothing => clothing.Id))
                    .ForMember(clothingVm => clothingVm.Model,
                            opt => opt.MapFrom(clothing => clothing.Model))
                    .ForMember(clothingVm => clothingVm.Articul,
                        opt => opt.MapFrom(clothing => clothing.Articul));
                    
                   
        }
    }
}
