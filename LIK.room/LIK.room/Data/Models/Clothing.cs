namespace LIK.room.Data.Models
{
    public class Clothing
    {
        public int Id { get; set; } 
        public string Model { get; set; }
        public int Articul { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public dynamic Size { get; set; }
        public ushort Price { get; set; }
        public bool IsAvailable { get; set; } 
        public string Imagine { get; set; }
        public bool IsFavourite { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }



    }
}
