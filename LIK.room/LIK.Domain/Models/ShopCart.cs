using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIK.room.Data.Models
{
    public class ShopCart
    {
        private readonly AppDBContent _appDBContent;
        public ShopCart(AppDBContent appDBContent)
        {
            _appDBContent = appDBContent;
        }

        public string ShopCartId { get; set; }
        public List<ShopCartItem> ListShopItems { get; set; }


        public static ShopCart GetCart(IServiceProvider services)  
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session; // создаем объект для работы с сессиями
            var context = services.GetService<AppDBContent>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString(); // устанавливаем в переменную значение из сессии или создаем новый идентификтор для корзины

            session.SetString("CartId", shopCartId);

            return new ShopCart(context) { ShopCartId = shopCartId };
        }


        public void AddToCart(Clothing clothing/*, int amount*/)
        {
            _appDBContent.ShopCartItem.Add(new ShopCartItem {
                                            ShopCartId = ShopCartId,
                                            Clothing = clothing,
                                            Price = clothing.Price,
            });

            _appDBContent.SaveChanges();
        }


        public List<ShopCartItem> getShopItems()
        {
            return _appDBContent.ShopCartItem.Where(c => c.ShopCartId == ShopCartId).Include(c => c.Clothing).ToList();
        }
    }
}
