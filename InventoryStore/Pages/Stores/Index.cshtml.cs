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
    public class IndexModel : PageModel
    {
        private readonly InventoryStore.Models.AppDbContext _context;

        public IndexModel(InventoryStore.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Store> Store { get;set; }

        public async Task OnGetAsync()
        {
            Store = await _context.Store.ToListAsync();
        }
    }
}
