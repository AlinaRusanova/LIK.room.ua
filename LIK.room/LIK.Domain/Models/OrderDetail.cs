using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIK.Domain.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int orderId { get; set; }
        public int ClothingId { get; set; }
        public uint Price { get; set; }
        public virtual Clothing Clothing { get; set; }
        public virtual Order Order { get; set; }
     
    }
}
