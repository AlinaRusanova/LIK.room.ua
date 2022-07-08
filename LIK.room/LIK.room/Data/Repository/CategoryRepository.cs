using LIK.room.Data.Interfaces;
using LIK.room.Data.Models;
using System.Collections.Generic;

namespace LIK.room.Data.Repository
{
    public class CategoryRepository : IClothingCategory
    {
        private readonly AppDBContent _appDBContent;
        public CategoryRepository(AppDBContent appDBContent)
        {
            _appDBContent = appDBContent;
        }
        public IEnumerable<Category> AllCategories => _appDBContent.Category;
    }
}
