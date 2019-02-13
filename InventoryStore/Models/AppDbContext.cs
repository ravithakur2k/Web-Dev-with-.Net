using Microsoft.EntityFrameworkCore;
using InventoryStore.Models;
using System.Collections.Generic;

namespace InventoryStore.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options)
        {
        }

        public DbSet<InventoryStore.Models.Inventory> Inventory { get; set; }
        public DbSet<InventoryStore.Models.Product> Product { get; set; }
        public DbSet<InventoryStore.Models.Store> Store { get; set; }
    }
}