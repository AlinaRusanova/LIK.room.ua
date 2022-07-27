using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using MediatR;

namespace LIK.Application.Features.Clothes.Queries.GetClothingList
{
   public class GetClothingListQuery : IRequest<ClothingListVm>
    {
        public int CategoryID { get; set; }

    }
}
