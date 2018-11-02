using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CouponManagement.Models;

namespace CouponManagement.Pages.CouponCategories
{
    public class EditModel : PageModel
    {
        private readonly CouponManagement.Models.AppDbContext _context;

        public EditModel(CouponManagement.Models.AppDbContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CouponCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CouponCategoryExists(CouponCategory.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CouponCategoryExists(int id)
        {
            return _context.CouponCategories.Any(e => e.Id == id);
        }
    }
}
