using Microsoft.EntityFrameworkCore;
using CouponManagement.Models;

namespace CouponManagement.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options)
        {
        }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<CouponCategory> CouponCategories { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Analyze> Analyze { get; set; }
        public DbSet<AnalysisForm> AnalysisForm { get; set; }
    }
}