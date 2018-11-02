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
    public class IndexModel : PageModel
    {
        private readonly CouponManagement.Models.AppDbContext _context;

        public IndexModel(CouponManagement.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<CouponCategory> CouponCategory { get;set; }

        public async Task OnGetAsync()
        {
            CouponCategory = await _context.CouponCategories.ToListAsync();
        }
    }
}
