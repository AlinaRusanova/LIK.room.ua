using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace LIK.Application.Features.Clothes.Queries.GetClothingDetails
{
  public  class GetClothingDetailsQuery: IRequest<ClothingDetailsVm>
    {
        public int Id { get; set; }
    }
}
