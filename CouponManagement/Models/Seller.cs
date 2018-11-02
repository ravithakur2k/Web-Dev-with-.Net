
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CouponManagement.Models
{
    public class Seller
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Seller Name")]
        [Required(ErrorMessage = "Please provide a name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage =" 3 - 50 characters only")]
        public string Name { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Please provide an address")]
        [StringLength(100, MinimumLength = 3, ErrorMessage =" 3 - 100 characters only")]
        public string Address { get; set; }

        [Display(Name = "Email Address")]
        [EmailAddress]
        [Required(ErrorMessage = "Please provide an email")]
        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Please provide a phone number")]    
        public long PhoneNumber { get; set;}
        public ICollection<Coupon> Coupons{ get; set; }
    }
}
            