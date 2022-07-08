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
    public class ShopCartController: Controller
    {
        private IClothing _clothRep;
        private readonly ShopCart _shopCart;
        public ShopCartController(IClothing clothRep, ShopCart shopCart)
        {
            _clothRep = clothRep;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.ListShopItems = items;
            var obj = new ShopCartViewModel { 
            shopCart = _shopCart};
            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _clothRep.AllClothing.FirstOrDefault(i => i.Id == id);
            if (item != null)
            { _shopCart.AddToCart(item); }

            return RedirectToAction("Index");


        }
    }
}
