using LIK.room.Data.Interfaces;
using LIK.room.Data.Models;
using LIK.room.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIK.room.Controllers
{
    public class HomeController: Controller
    {
        private IClothing _clothRep;
        
        public HomeController(IClothing clothRep)
        {
            _clothRep = clothRep;           
        }

        public ViewResult Index()
        {
            var HomeClothes = new HomeViewModel { 
            favCloth = _clothRep.getFavCloth
            };
            return View(HomeClothes);
        }

    }
}
