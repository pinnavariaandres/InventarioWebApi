using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Invetory.Entities
{
    public class MovementType
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; }= string.Empty;

        public bool IsIncoming { get; set; }
        public bool IsOutcoming { get; set; }

        public bool IsInternalTransfer { get; set; }

          public DateTime CreatedAD { get; set; }
         public DateTime UpdatedAt { get; set; }
    }
}