using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InventoryStore.Models;

namespace InventoryStore.Pages.Stores
{
    public class DetailsModel : PageModel
    {
        private readonly InventoryStore.Models.AppDbContext _context;

        public DetailsModel(InventoryStore.Models.AppDbContext context)
        {
            _context = context;
        }

        public Store Store { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Store = await _context.Store.FirstOrDefaultAsync(m => m.Id == id);

            if (Store == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
