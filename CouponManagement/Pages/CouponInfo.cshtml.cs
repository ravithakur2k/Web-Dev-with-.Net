using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CouponManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CouponManagement.Pages
{
    public class CouponInfoModel : PageModel
    {
        private AppDbContext _context;
        public CouponInfoModel(AppDbContext context){
              _context = context;
         }

        public CouponCategory CouponCategory { get; set; }
        public IActionResult OnGet(int? id)
        {
            if (id == null)
                {
                    return NotFound();
                }

            CouponCategory = _context.CouponCategories
                                  .Include(cou => cou.Coupons)
                                  .FirstOrDefault(cou => cou.Id == id);

            if(CouponCategory == null)
                {
                    return NotFound();
                }

            return Page();
        }
    }
}