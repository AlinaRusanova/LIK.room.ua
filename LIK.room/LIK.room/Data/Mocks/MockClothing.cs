using LIK.room.Data.Interfaces;
using LIK.room.Data.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace LIK.room.Data.Mocks
{  
    public class MockClothing : IClothing
    {
        private readonly IClothingCategory _clothingCategory = new MockCategory();
        public IEnumerable<Clothing> AllClothing 
        {
            get {
                return new List<Clothing> { };
            //{
            //new Clothing {
            //    Model = "Сукня-міді в квітковий принт",
            //    Articul = 10789, Color = "Колір: бежева в блакитні квіти, бежева в рожеві квіти",
            //    Description = "", Price = 1200,
            //    IsFavourite = true,
            //    IsAvailable = true,
            //    Size = "S" ,
            //    Imagine = "/img/сукня-міді.jpg",
            //    Category = _clothingCategory.AllCategories.ElementAt(0)
            //    },
            //new Clothing {
            //    Model = "Шкіряна спідниця на запАх", 
            //    Articul = 10743, Color = "Колір: коричневий,чорний", 
            //    Description = "", Price = 750, 
            //    IsFavourite = true, 
            //    IsAvailable = true, Size = "M, L" , 
            //    Imagine = "/img/шкіряна спідниця.jpg",
            //    Category = _clothingCategory.AllCategories.ElementAt(1)
            //},
            //new Clothing {
            //    Model = "Сорочка з вирізом до ліктя", 
            //    Articul = 10789, 
            //    Color = "Колір: білий",
            //    Description = "", 
            //    Price = 1000, 
            //    IsFavourite = true, 
            //    IsAvailable = true, 
            //    Size = "M" , 
            //    Imagine = "/img/сорочка.jpg",
            //    Category = _clothingCategory.AllCategories.ElementAt(2)
            //},

            //};
            }
        
        }
       public IEnumerable<Clothing> getFavCloth { get; set; }

        public Clothing getObjectCloth(int IdCloth)
        {
            throw new System.NotImplementedException();
        }
    }
}
