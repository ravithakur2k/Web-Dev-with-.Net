using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CouponManagement.Models;

namespace CouponManagement.Pages.CouponCategories
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
            return Page();
        }

        [BindProperty]
        public CouponCategory CouponCategory { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CouponCategories.Add(CouponCategory);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}