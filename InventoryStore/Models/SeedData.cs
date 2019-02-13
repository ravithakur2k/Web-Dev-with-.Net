using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace InventoryStore.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                
                // if (context.Inventory.Any()) {
                //             return;
                //         }
                //         context.Inventory.AddRange(
                //             new Inventory { InventoryName = "PC's", Quantity= 1500},
                //             new Inventory { InventoryName =  "Laptops", Quantity= 1000 },
                //             new Inventory { InventoryName = "Printers", Quantity= 200 },
                //             new Inventory { InventoryName = "HeadPhones", Quantity= 2500 },
                //             new Inventory { InventoryName = "Television", Quantity= 100 }
                //         );
                context.SaveChanges();
            }
        }
    }
}