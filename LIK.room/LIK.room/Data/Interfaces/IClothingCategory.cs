using LIK.room.Data.Models;
using System.Collections.Generic;

namespace LIK.room.Data.Interfaces
{
    public interface IClothingCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
