using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CouponManagement.Models;

namespace CouponManagement.Pages.Coupons
{
    public class DetailsModel : PageModel
    {
        private readonly CouponManagement.Models.AppDbContext _context;

        public DetailsModel(CouponManagement.Models.AppDbContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
