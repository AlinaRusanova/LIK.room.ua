using Microsoft.AspNetCore.Mvc;
using LIK.room.Data.Interfaces;
using LIK.room.ViewModels;
using System.Collections.Generic;
using LIK.room.Data.Models;
using System.Linq;
using System;

namespace LIK.room.Controllers
{
    public class ClothesController: Controller
    {
        private readonly IClothing _allClothing;
        private readonly IClothingCategory _allCategory;

        public ClothesController(IClothing iAllClothing, IClothingCategory iAllCategory)
        {
            _allClothing = iAllClothing;
            _allCategory = iAllCategory;
        }

        [Route("Clothes/List")]
        [Route("Clothes/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Clothing> clothes;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            { clothes = _allClothing.AllClothing.OrderBy(c => c.Id); }
            else
            {
                clothes = _allClothing.AllClothing.Where(c => c.Category.CategoryName.Equals(category,StringComparison.InvariantCultureIgnoreCase)).OrderBy(c => c.Id);
                //if (string.Equals("skirt", category, System.StringComparison.OrdinalIgnoreCase))
                //{ clothes = _allClothing.AllClothing.Where(c=> c.Category.CategoryName.Equals("спідниці")).OrderBy(c => c.Id); }
            }
            currCategory = _category;
            var clothObj = new ClothesListViewModel
            {
                allClothing = clothes,
                currCategory = currCategory
            };

            ViewBag.Title = "Сторінка з одягом";
            //ClothesListViewModel obj = new ClothesListViewModel();
            //obj.allClothing = _allClothing.AllClothing;
            //obj.currCategory = "Одяг";
            return View(clothObj);
        }

    }
}
