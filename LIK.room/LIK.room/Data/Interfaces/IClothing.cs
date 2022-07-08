using LIK.room.Data.Models;
using System.Collections.Generic;

namespace LIK.room.Data.Interfaces
{
    public interface IClothing
    {
        IEnumerable<Clothing> AllClothing { get; }
        IEnumerable<Clothing> getFavCloth { get; }
        Clothing getObjectCloth (int IdCloth);

    }
}
