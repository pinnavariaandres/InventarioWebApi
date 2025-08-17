using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Invetory.Entities;
using Invetory.Persistence.Interfaces;

namespace Invetory.Persistence.Repositories
{
    public class InventoryMovementRepository :BaseRepository<InventoryMovement>,IInventoryMovementRepository
    {
        public InventoryMovementRepository(DataContext context):base (context)
        {
            
        }
    }
}