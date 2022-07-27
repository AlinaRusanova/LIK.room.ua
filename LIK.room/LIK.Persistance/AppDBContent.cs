using LIK.Application.Interfaces;
using LIK.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace LIK.Persistence
{
    public class AppDBContent: DbContext, IAppDBContent  // класс для работы с бд
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }

        public DbSet<Clothing> Clothing { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ShopCartItem> ShopCartItem { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }

    }
}
