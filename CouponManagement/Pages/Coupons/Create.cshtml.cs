using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CouponManagement.Models;

namespace CouponManagement.Pages.Coupons
{
    public class CreateModel : PageModel
    {
        private readonly CouponManagement.Models.AppDbContext _context;

        public CreateModel(CouponManagement.Models.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CategoryId"] = new SelectList(_context.CouponCategories, "Id", "Name");
        ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Name");
        ViewData["SellerId"] = new SelectList(_context.Sellers, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public Coupon Coupon { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ViewData["CategoryId"] = new SelectList(_context.CouponCategories, "Id", "Name");
                ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Name");
                ViewData["SellerId"] = new SelectList(_context.Sellers, "Id", "Name");
                return Page();
            }

            _context.Coupons.Add(Coupon);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}