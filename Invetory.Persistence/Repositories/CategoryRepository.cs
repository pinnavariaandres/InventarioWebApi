using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Invetory.Entities;
using Invetory.Persistence.Interfaces;

namespace Invetory.Persistence.Repositories
{
    public class CategoryRepository :BaseRepository<Category>,ICategoryRepository
    {
        public CategoryRepository(DataContext context):base (context)
        {
            
        }
    }
}