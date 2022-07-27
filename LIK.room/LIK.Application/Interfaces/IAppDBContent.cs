using LIK.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LIK.Application.Interfaces
{
    public interface IAppDBContent
    {
        DbSet<Clothing> Clothing {get;set;}
         DbSet<Category> Category { get; set; }
         DbSet<ShopCartItem> ShopCartItem { get; set; }
         DbSet<Order> Order { get; set; }
         DbSet<OrderDetail> OrderDetail { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
