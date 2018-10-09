using Microsoft.EntityFrameworkCore;
using CoreCrud.Models;

namespace CoreCrud.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options)
        {
        }

         public DbSet<CoreCrud.Models.Destination> Destination { get; set; }
			  
		 public DbSet<CoreCrud.Models.Country> Country { get; set; }
    }
}