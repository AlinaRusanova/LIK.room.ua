using LIK.Domain.Models;
using System.Collections.Generic;

namespace LIK.Application.Interfaces
{
    public interface IClothing
    {
        IEnumerable<Clothing> AllClothing { get; }
        IEnumerable<Clothing> getFavCloth { get; }
        Clothing getObjectCloth (int IdCloth);

    }
}
