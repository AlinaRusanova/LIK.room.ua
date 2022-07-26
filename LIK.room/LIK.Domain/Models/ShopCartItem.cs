using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIK.room.Data.Models
{
    public class ShopCartItem
    {
        public int Id { get; set; }
        public Clothing Clothing { get; set; }
        public int Price { get; set; }
        public string ShopCartId { get; set; }
        // add amount
    }
}
