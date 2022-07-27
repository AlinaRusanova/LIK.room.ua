using LIK.Application.Interfaces;
using LIK.Domain.Models;
using LIK.Persistence.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIK.room.Controllers
{
    public class OrderController:Controller
    {
        private readonly IAllOrders _allOrders;
        private readonly ShopCartRepository _shopCart;

        public OrderController(IAllOrders allOrders, ShopCartRepository shopCart)
        {
            _allOrders = allOrders;
            _shopCart = shopCart;
        }

        public IActionResult CheckOut()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckOut(Order order)
        {
            _shopCart.ListShopItems = _shopCart.getShopItems();
          
            if ( _shopCart.ListShopItems.Count() == 0)
            { ModelState.AddModelError("", "Корзина має містити товари"); };

            if (ModelState.IsValid)
            { _allOrders.CreateOrder(order);
            return RedirectToAction("Complete");
            }
            return View(order);
        }

        public IActionResult Complete()
        {
            
            ViewBag.Message = "Дякуємо за замовлення!";
            return View();
        }

    }
}
