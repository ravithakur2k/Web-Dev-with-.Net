using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CouponManagement.Models;

namespace CouponManagement.Pages.Sellers
{
    public class DetailsModel : PageModel
    {
        private readonly CouponManagement.Models.AppDbContext _context;

        public DetailsModel(CouponManagement.Models.AppDbContext context)
        {
            _context = context;
        }

        public Seller Seller { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Seller = await _context.Sellers.FirstOrDefaultAsync(m => m.Id == id);

            if (Seller == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
