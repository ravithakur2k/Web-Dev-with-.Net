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
    public class QuickGlanceModel : PageModel
    {

        private AppDbContext _context;
        public QuickGlanceModel(AppDbContext context){
              _context = context;
         }
        public void OnGet() => Coupons = _context.Coupons
                .Include(c => c.Category)
                .OrderBy(c => c.Name)
                .ToList();
        public List<Coupon> Coupons { get; set; }
        }
    }