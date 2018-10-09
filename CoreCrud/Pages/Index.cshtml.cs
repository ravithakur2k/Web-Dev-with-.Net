using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreCrud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CoreCrud.Pages
{
    public class IndexModel : PageModel
    {

        private AppDbContext _context;
        public IndexModel(AppDbContext context) {
            _context = context;
        }
        public void OnGet() {
            CountOfCountries = _context.Country
                                    .Count();

            CountOfDestinations = _context.Destination
                                    .Count();

            CountofEnjoyableDestinations = _context.Destination
                                    .Where(x => x.isEnjoyable == true)
                                    .Count();

            CountOfNotSoEnjoyableDestinations = _context.Destination
                                    .Where(x => x.isEnjoyable == false)
                                    .Count();
        }
            public int CountOfCountries { get; set; }
            public int CountOfDestinations { get; set; }
            public int CountofEnjoyableDestinations { get; set; }
            public int CountOfNotSoEnjoyableDestinations { get; set; }
                    
    }
}
