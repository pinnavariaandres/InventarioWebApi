using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Invetory.Entities;
using Invetory.Persistence.Interfaces;

namespace Invetory.Persistence.Repositories
{
   
    
    public class SupplierRepository : BaseRepository<Supplier>, ISupplierRepository
    {
        public SupplierRepository(DataContext context) : base(context)
        {

        }
    }
}