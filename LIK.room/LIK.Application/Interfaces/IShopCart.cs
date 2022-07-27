using LIK.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LIK.Application.Interfaces
{
    public interface IShopCartItem
    {
        //public string ShopCartId { get; set; }
        //public List<ShopCartItem> ListShopItems { get; set; }
        void AddToCart(Clothing clothing);
        List<ShopCartItem> getShopItems();
    }
}
