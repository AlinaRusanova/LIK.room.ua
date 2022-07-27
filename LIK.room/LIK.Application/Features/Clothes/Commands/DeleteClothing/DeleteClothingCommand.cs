using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LIK.Application.Features.Clothes.Commands.DeleteClothing
{
 public class DeleteClothingCommand: IRequest
    {
        public int Id { get; set; }
    }
}
