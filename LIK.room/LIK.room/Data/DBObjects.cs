using LIK.room.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace LIK.room.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
            { content.Category.AddRange(Categories.Select(c => c.Value)); }

            if (!content.Clothing.Any())
            {
                content.AddRange(
              //     new Clothing
              //     {
              //         Model = "Сукня-міді в квітковий принт",
              //         Articul = 10789,
              //         Color = "Колір: бежева в блакитні квіти, бежева в рожеві квіти",
              //         Description = "",
              //         Price = 1200,
              //         IsFavourite = true,
              //         IsAvailable = true,
              //         Size = "S",
              //         Imagine = "/img/сукня-міді.jpg",
              //         Category = Categories["Сукні"]
              //     },
              //new Clothing
              //{
              //    Model = "Шкіряна спідниця на запАх",
              //    Articul = 10743,
              //    Color = "Колір: коричневий,чорний",
              //    Description = "",
              //    Price = 750,
              //    IsFavourite = true,
              //    IsAvailable = true,
              //    Size = "M, L",
              //    Imagine = "/img/шкіряна спідниця.jpg",
              //    Category = Categories["Спідниці"]
              //},
              //new Clothing
              //{
              //    Model = "Сорочка з вирізом до ліктя",
              //    Articul = 10789,
              //    Color = "Колір: білий",
              //    Description = "",
              //    Price = 1000,
              //    IsFavourite = true,
              //    IsAvailable = true,
              //    Size = "M",
              //    Imagine = "/img/сорочка.jpg",
              //    Category = Categories["Сорочки"]
              //}
                  ); 
            }

            content.SaveChanges();

        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories 
        {
            get {
                if (category == null)
                {
                    var list = new Category[]
                   {
                new Category{ CategoryName = "Сукні"},
                new Category { CategoryName = "Спідниці" },
                new Category { CategoryName = "Сорочки" }
                   };
                    category = new Dictionary<string, Category>();
                    foreach (var el in list)
                    {
                        category.Add(el.CategoryName, el);
                    }
                }
                return category;
            }           
        }
    }
}
