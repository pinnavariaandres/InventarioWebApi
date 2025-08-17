using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Invetory.Entities
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public string ContactPerson { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Adress { get; set; } = string.Empty;

        public DateTime CreatedAt  { get; set; }

         public DateTime UpdateAt  { get; set; }

        public IEnumerable<Product>? Products { get; set; }

    }
}