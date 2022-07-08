using LIK.room.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace LIK.room.Data
{
    public class AppDBContent: DbContext  // класс для работы с бд
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }

        public DbSet<Clothing> Clothing { get; set; }
        public DbSet<Category> Category { get; set; }

    }
}
