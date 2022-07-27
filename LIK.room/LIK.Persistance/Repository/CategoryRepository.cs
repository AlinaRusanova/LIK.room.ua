using LIK.Application.Interfaces;
using LIK.Domain.Models;
using System.Collections.Generic;

namespace LIK.Persistence.Repository
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
