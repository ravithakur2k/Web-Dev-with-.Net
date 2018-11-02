using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CouponManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace CouponManagement.Pages
{
    public class SearchCouponsModel : PageModel
    {
        private AppDbContext _context;
        
        public SearchCouponsModel(AppDbContext context) {
            _context = context;
        }
        
        public void OnGet()
        {
          SearchCompleted = false;
        }
        
        // THE 'BindProperty' Search will receive the value from the form
        // Note: The name attribute of the input in the HTML matches this name
        [BindProperty]
        public string Search { get; set; } 
        
        // WE WILL USE THIS PROPERTY TO TRACK IF A SEARCH HAS BEEN PERFORMED
        public bool SearchCompleted { get; set; }
        
        // WE WILL STORE THE RESULTS IN THIS PROPERTY
        public ICollection<Coupon> SearchResults { get; set; }
        
        public void OnPost() {
            // PERFORM SEARCH
            if (string.IsNullOrWhiteSpace(Search)) {
                // EXIT EARLY IF THERE IS NO SEARCH TERM PROVIDED
                return;
            }
            SearchResults = _context.Coupons
                                    .Where(x => x.Name.ToLower().Contains(Search.ToLower()))
                                    .OrderBy(x => x.Id)
                                    .ToList();
            SearchCompleted = true;
        }
    }
}