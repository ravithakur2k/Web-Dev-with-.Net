
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CouponManagement.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Customer First Name")]
        [Required(ErrorMessage = "Please provide first name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage =" 3 - 50 characters only")]
        public string FirstName { get; set; }

        [Display(Name = "Customer Last Name")]
        [Required(ErrorMessage = "Please provide last name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage =" 3 - 50 characters only")]
        public string LastName { get; set; }

        public string Name{
            get{
                string firstName = FirstName.ToUpper();
                string lastName = LastName.ToUpper();
                return firstName+" "+lastName;
            }
        }

        [Display(Name = "Street Address")]
        [Required(ErrorMessage = "Please provide a Street Address")]
        [StringLength(100, MinimumLength = 3, ErrorMessage =" 3 - 100 characters only")]
        public string StreetAddress { get; set; }

        [Display(Name = "Zip Code")]
        [Required(ErrorMessage = "Please provide a Zip Code")]
        //[Range(5,15, ErrorMessage =" 5 - 15 characters only")]
        public int ZipCode { get; set; }

        public string Address{
            get{
                return StreetAddress+" - "+ZipCode;
            }
        }

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