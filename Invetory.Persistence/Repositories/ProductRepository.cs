using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Invetory.Entities;
using Invetory.Persistence.Interfaces;

namespace Invetory.Persistence.Repositories
{
    
    
  public class ProductRepository : BaseRepository<Product>, IProductReposotory
    {
        public ProductRepository(DataContext context) : base(context)
        {

        }
    }
}