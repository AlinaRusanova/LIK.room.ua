using LIK.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIK.Application.Interfaces
{
   public interface IAllOrders
    {
        Task CreateOrder(Order order);
        
    }
}
