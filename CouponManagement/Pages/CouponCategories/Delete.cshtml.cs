using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CouponManagement.Models;

namespace CouponManagement.Pages.CouponCategories
{
    public class DeleteModel : PageModel
    {
        private readonly CouponManagement.Models.AppDbContext _context;

        public DeleteModel(CouponManagement.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CouponCategory CouponCategory { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CouponCategory = await _context.CouponCategories.FirstOrDefaultAsync(m => m.Id == id);

            if (CouponCategory == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CouponCategory = await _context.CouponCategories.FindAsync(id);

            if (CouponCategory != null)
            {
                _context.CouponCategories.Remove(CouponCategory);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
