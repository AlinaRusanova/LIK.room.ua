using Microsoft.AspNetCore.Mvc;
using LIK.room.Data.Interfaces;
using LIK.room.ViewModels;

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

        public ViewResult List()
        {
            ViewBag.Title = "Сторінка з одягом";
            ClothesListViewModel obj = new ClothesListViewModel();
            obj.allClothing = _allClothing.AllClothing;
            obj.currCategory = "Одяг";
            return View(obj);
        }

    }
}
