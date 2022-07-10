using LIK.room.Data.Interfaces;
using LIK.room.Data.Models;
using System.Collections.Generic;

namespace LIK.room.Data.Mocks
{
    public class MockCategory : IClothingCategory
    {
       public IEnumerable<Category> AllCategories
        {
            get {
                return new List<Category>
                {
                new Category{ CategoryName = "Сукні"},
                new Category { CategoryName = "Спідниці" },
                new Category { CategoryName = "Сорочки" }
                };
            }
        }

      
    }
}
