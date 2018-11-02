using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CouponManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CouponManagement.Pages
{
    public class IndexModel : PageModel
    {
        private AppDbContext _context;
        public IndexModel(AppDbContext context) {
            _context = context;
        }
        public void OnGet()
        {
            CountOfCategories = _context.CouponCategories.Count();

            CountofCoupons = _context.Coupons.Count();

            CountOfRatingEqualTo5 = _context.Coupons
                                    .Where(x => x.Rating == 5)
                                    .Count();

            CountOfRatingEqualTo1 = _context.Coupons
                                    .Where(x => x.Rating == 1)
                                    .Count();

            CountOfExpiredCoupons = _context.Coupons
                                    .Where(x => x.ExpiryDate < DateTime.Today)
                                    .Count();

            }
            public int CountOfCategories { get; set; }
            public int CountofCoupons { get; set; }
            public int CountOfRatingEqualTo5 { get; set; }
            public int CountOfRatingEqualTo1 { get; set; }
            public int CountOfExpiredCoupons { get; set; }
            public int PersonWithMaxCoupons { get; set; }

    }
}
