using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CouponManagement.Models;

namespace CouponManagement.Pages
{
    public class CouponExpiryModel : PageModel
    {
        private readonly AppDbContext _context;

public CouponExpiryModel(AppDbContext context)
        {
            _context = context;
        }


[BindProperty]
        public ExpireCouponForm ExpireCouponForm { get; set; }
        
        public Coupon Coupon { get; set; }
        
public IActionResult OnGet(int? id)
        {
            if (id == null) {
                return NotFound();
            }
        Coupon = _context.Coupons.Find(id);

           if (Coupon == null) {
                return NotFound();
            }
        
            ExpireCouponForm = new ExpireCouponForm();
            ExpireCouponForm.CouponId = Coupon.Id;
            return Page(); 
    }

 public IActionResult OnPost() {
            Coupon = _context.Coupons.Find(ExpireCouponForm.CouponId);
            
            if (!ModelState.IsValid) {
                 return Page();
            }

// UPDATE THE COUPON RETRIEVED FROM THE DATABASE
            Coupon.ExpiryDate = ExpireCouponForm.ExpiryDate;
            // TELL THE DATABASE TO SAVE WHATEVER CHANGES WE MADE
            _context.SaveChanges();
            return RedirectToPage("/CouponExpiry", new  { id = Coupon.Id });
        }
    }
}
