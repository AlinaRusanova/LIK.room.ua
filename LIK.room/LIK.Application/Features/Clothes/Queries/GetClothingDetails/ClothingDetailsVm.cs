using AutoMapper;
using LIK.Application.Common.Mappings;
using LIK.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LIK.Application.Features.Clothes.Queries.GetClothingDetails
{
 public class ClothingDetailsVm: IMapWith<Clothing>
    {
        public string Model { get; set; }
        public int Articul { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public ushort Price { get; set; }
        public bool IsAvailable { get; set; }
        public string Imagine { get; set; }
        public bool IsFavourite { get; set; }
        public virtual Category Category { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Clothing, ClothingDetailsVm>()
                    .ForMember(clothingVm => clothingVm.Model,
                            opt => opt.MapFrom(clothing => clothing.Model))
                    .ForMember(clothingVm => clothingVm.Articul,
                        opt => opt.MapFrom(clothing => clothing.Articul))
                    .ForMember(clothingVm => clothingVm.Color,
                       opt => opt.MapFrom(clothing => clothing.Color))
                    .ForMember(clothingVm => clothingVm.Description,
                       opt => opt.MapFrom(clothing => clothing.Description))
                    .ForMember(clothingVm => clothingVm.Size,
                      opt => opt.MapFrom(clothing => clothing.Size))
                    .ForMember(clothingVm => clothingVm.Price,
                       opt => opt.MapFrom(clothing => clothing.Price))
                    .ForMember(clothingVm => clothingVm.IsAvailable,
                       opt => opt.MapFrom(clothing => clothing.IsAvailable))
                    .ForMember(clothingVm => clothingVm.Imagine,
                       opt => opt.MapFrom(clothing => clothing.Imagine))
                    .ForMember(clothingVm => clothingVm.IsFavourite,
                       opt => opt.MapFrom(clothing => clothing.IsFavourite))
                    .ForMember(clothingVm => clothingVm.Category,
                       opt => opt.MapFrom(clothing => clothing.Category));
        }

    }
}
