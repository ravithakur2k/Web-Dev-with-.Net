using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CouponManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace CouponManagement.Pages
{
    public class AnalysisModel : PageModel
    {
        private readonly AppDbContext _context;
            public AnalysisModel(AppDbContext context)
            {
                _context = context;
            }

            [BindProperty]
            public AnalysisForm AnalysisForm { get; set; }

            public bool AnalysisCompleted { get; set; }
            public ICollection<Customer> Cust { get; set; }
            public ICollection<Customer> Cst { get; set; }
            public void OnGet()
            {
                AnalysisCompleted = false;
                PopulateSelectLists();
            }
            
            public IActionResult OnPost()
            {
                
                if (!ModelState.IsValid) {
                    PopulateSelectLists();
                    return Page();
                }
            
                var analysis = new Analyze();
                analysis.CustomerId = AnalysisForm.CustomerId;
                analysis.AnalysisDate = DateTime.Now;
                _context.Analyze.Add(analysis);
                _context.SaveChanges();

                Cst = _context.Customers
                                .Include(x=>x.Coupons)
                                .Where(y=>y.Id==AnalysisForm.CustomerId)
                                .ToList();

                CountOfCoupons = _context.Coupons
                                .Where(y=>y.CustomerId==AnalysisForm.CustomerId).Count();

                TotalPriceOfCoupons = _context.Coupons
                                .Where(y=>y.CustomerId==AnalysisForm.CustomerId)
                                .Sum(z=>z.Price);

                MinPrice = _context.Coupons
                                .Where(y=>y.CustomerId==AnalysisForm.CustomerId)
                                .Min(z=>z.Price);

                MaxPrice = _context.Coupons
                                .Where(y=>y.CustomerId==AnalysisForm.CustomerId)
                                .Max(z=>z.Price);

                Cust = _context.Customers.ToList();
                ViewData["CustomerId"] = new SelectList(Cust, "Id", "Name");
                AnalysisCompleted = true;
                //return RedirectToPage("/Analysis", new { Id = AnalysisForm.CustomerId });
                return Page();
            }
            public int CountOfCoupons {get; set;}
            public int MinPrice {get; set;}
            public int MaxPrice {get; set;}

            public int TotalPriceOfCoupons {get; set;}
            private void PopulateSelectLists() {
                // GET ALL ANALYSIS
                Cust = _context.Customers.ToList();
                ViewData["CustomerId"] = new SelectList(Cust, "Id", "Name");
            }
    }
}