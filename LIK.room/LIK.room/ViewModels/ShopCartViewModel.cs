using LIK.Application.Interfaces;
using LIK.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LIK.room.ViewModels
{
    public class ShopCartViewModel
    {
        public ShopCartRepository shopCart { get; set; }
    }
}
