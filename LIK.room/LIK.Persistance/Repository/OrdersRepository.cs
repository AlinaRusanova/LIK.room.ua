using LIK.Application.Interfaces;
using LIK.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIK.Persistence.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent _appDBContent;
        private readonly ShopCartRepository _shopCart;

        public OrdersRepository(AppDBContent appDBContent, ShopCartRepository shopCart)
        {
            _appDBContent = appDBContent;
            _shopCart = shopCart;
        }
        public async Task CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
          await Task.FromResult( _appDBContent.Order.AddAsync(order));
            await Task.FromResult(_appDBContent.SaveChangesAsync());

            var items = _shopCart.ListShopItems;

            foreach (var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    ClothingId = el.Clothing.Id,
                    orderId = order.Id,
                    Price = el.Clothing.Price
                };
                await Task.FromResult(_appDBContent.OrderDetail.AddAsync(orderDetail));
            }
            await Task.FromResult(_appDBContent.SaveChangesAsync());
        }
    }
}
