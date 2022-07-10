using LIK.room.Data.Models;
using System.Collections.Generic;

namespace LIK.room.ViewModels
{
    public class ClothesListViewModel
    {
        public IEnumerable<Clothing> allClothing { get; set; }
        public string currCategory { get; set; }    

    }
}
