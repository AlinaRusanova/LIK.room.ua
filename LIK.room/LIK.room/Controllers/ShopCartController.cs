using LIK.Application.Interfaces;
using LIK.Domain.Models;
using LIK.Persistence.Repository;
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
        private readonly ShopCartRepository _shopCart;
        public ShopCartController(IClothing clothRep, ShopCartRepository shopCart)
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
