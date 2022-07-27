using LIK.Application.Interfaces;
using LIK.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LIK.Persistence.Repository
{
    public class ClothingRepository : IClothing
    {
        private readonly AppDBContent _appDBContent;
        public ClothingRepository(AppDBContent appDBContent)
        {
            _appDBContent = appDBContent;   
        }
        public IEnumerable<Clothing> AllClothing => _appDBContent.Clothing.Include(c => c.Category);

        public IEnumerable<Clothing> getFavCloth => _appDBContent.Clothing.Where(c => c.IsFavourite).Include(c => c.Category);

        public Clothing getObjectCloth(int IdCloth) => _appDBContent.Clothing.FirstOrDefault(c => c.Id == IdCloth);

        }
    }

