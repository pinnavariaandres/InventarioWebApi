using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Invetory.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


namespace Invetory.Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :
        base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<InventoryMovement> InventoryMovements { get; set; }
        public DbSet<InventoryStock> InventoryStocks { get; set; }
        public DbSet<MovementType> MovementTypes { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }
    }
}