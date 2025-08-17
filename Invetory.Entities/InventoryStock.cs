using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Invetory.Entities
{
    public class InventoryStock
    {
        public int Id { get; set; }
     

        public int Quantity { get; set; }
        public string Location { get; set; } = string.Empty;

        public DateTime CreatedAD { get; set; }
        public DateTime UpdatedAt { get; set; }

        public int ProductId { get; set; }
        
        public Product? Product { get; set; }
    }
}