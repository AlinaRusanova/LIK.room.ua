using System.Collections.Generic;

namespace LIK.Domain.Models
{
    public class Category
    {
        public int ID { get; set; }   
        public string CategoryName { get; set; }
        // public string Desc { get; set; }

        public string CategoryImage { get; set; }
        public List<Clothing> clothes { get; set; }


    }
}
