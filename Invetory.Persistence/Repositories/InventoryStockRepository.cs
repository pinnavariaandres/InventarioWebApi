using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Invetory.Entities;
using Invetory.Persistence.Interfaces;

namespace Invetory.Persistence.Repositories
{
    public class InventoryStockRepository : BaseRepository<InventoryStock>, IInventoryStockRepository
    {
        public InventoryStockRepository(DataContext context) : base(context)
        {

        }
    }
}