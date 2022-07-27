using LIK.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LIK.Application.Features.Clothes.Commands.CreateClothing
{
   public class CreateClothingCommand: IRequest<int>
    {
        public string Model { get; set; }
        public int Articul { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public ushort Price { get; set; }
        public ushort Count { get; set; }
        public string Imagine { get; set; }
        //public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
