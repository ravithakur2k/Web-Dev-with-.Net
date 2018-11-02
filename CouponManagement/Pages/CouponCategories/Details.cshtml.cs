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
    public class DetailsModel : PageModel
    {
        private readonly CouponManagement.Models.AppDbContext _context;

        public DetailsModel(CouponManagement.Models.AppDbContext context)
        {
            _context = context;
        }

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
    }
}
