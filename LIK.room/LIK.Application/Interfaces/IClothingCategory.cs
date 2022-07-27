using LIK.Domain.Models;
using System.Collections.Generic;

namespace LIK.Application.Interfaces
{
    public interface IClothingCategory
    {
        IEnumerable<Category> AllCategories { get;  }
    }
}
