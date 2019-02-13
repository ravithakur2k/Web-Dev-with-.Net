using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using InventoryStore.Models;

namespace InventoryStore.Pages.Inventories
{
    public class CreateModel : PageModel
    {
        private readonly InventoryStore.Models.AppDbContext _context;

        public CreateModel(InventoryStore.Models.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ProductID"] = new SelectList(_context.Product, "Id", "Id");
        ViewData["StoreID"] = new SelectList(_context.Store, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Inventory Inventory { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Inventory.Add(Inventory);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}