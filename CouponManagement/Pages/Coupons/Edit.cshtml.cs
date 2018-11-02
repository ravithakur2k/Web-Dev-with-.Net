using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CouponManagement.Models;

namespace CouponManagement.Pages.Coupons
{
    public class EditModel : PageModel
    {
        private readonly CouponManagement.Models.AppDbContext _context;

        public EditModel(CouponManagement.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Coupon Coupon { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Coupon = await _context.Coupons
                .Include(c => c.Category)
                .Include(c => c.Customer)
                .Include(c => c.Seller).FirstOrDefaultAsync(m => m.Id == id);

            if (Coupon == null)
            {
                return NotFound();
            }
           ViewData["CategoryId"] = new SelectList(_context.CouponCategories, "Id", "Name");
           ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Name");
           ViewData["SellerId"] = new SelectList(_context.Sellers, "Id", "Name");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ViewData["CategoryId"] = new SelectList(_context.CouponCategories, "Id", "Name");
                ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Name");
                ViewData["SellerId"] = new SelectList(_context.Sellers, "Id", "Name");
                return Page();
            }

            _context.Attach(Coupon).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CouponExists(Coupon.Id))
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

        private bool CouponExists(int id)
        {
            return _context.Coupons.Any(e => e.Id == id);
        }
    }
}
