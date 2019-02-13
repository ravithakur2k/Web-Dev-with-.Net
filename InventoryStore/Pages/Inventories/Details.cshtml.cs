using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InventoryStore.Models;

namespace InventoryStore.Pages.Inventories
{
    public class DetailsModel : PageModel
    {
        private readonly InventoryStore.Models.AppDbContext _context;

        public DetailsModel(InventoryStore.Models.AppDbContext context)
        {
            _context = context;
        }

        public Inventory Inventory { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Inventory = await _context.Inventory
                .Include(i => i.Product)
                .Include(i => i.Store).FirstOrDefaultAsync(m => m.Id == id);

            if (Inventory == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
