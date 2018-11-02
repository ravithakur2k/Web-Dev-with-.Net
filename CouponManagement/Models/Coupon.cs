
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CouponManagement.Models
{
    public class Coupon
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Coupon Name")]
        [Required(ErrorMessage = "Please provide the coupon name")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "2 - 100 characters only")]       
        public string Name { get; set; }

        [Display(Name = "Validity start date")]
        [Required(ErrorMessage = "Please provide the first date the coupon can be redeemed")]
        [DataType(DataType.Date)]
        [CustomValidation(typeof(Coupon), "StartDateInTheFuture")]
        public DateTime? ValidDate { get; set; }

        [Display(Name = "Expiry date")]
        [Required(ErrorMessage = "Please provide the last date the coupon can be redeemed")]
        [DataType(DataType.Date)]
        [CustomValidation(typeof(Coupon), "ExpiryDateGreaterThanStartDate")]
        public DateTime? ExpiryDate { get; set; }

        [Display(Name = "Price of the coupon ")]
        [Required(ErrorMessage = "Please provide the price of the coupon")]
        [Range(1, 20, ErrorMessage = "Between 1 - 20 dollars only")]  
        public int Price { get; set; }

        [Display(Name = "Coupon Rating ")]
        [Range(1, 5, ErrorMessage = "Between 1 - 5 only")] 
        public int Rating { get; set; }

        public string Validity{
            get{
                return ValidDate+" - "+ExpiryDate;
            }
        }

        //RELATIONSHIPS

        [Display(Name = "Coupon Category")]
        public int CategoryId { get; set; }
        public CouponCategory Category { get; set; }

        [Display(Name = "Seller Name")]
        public int SellerId { get; set; }
       
        public Seller Seller { get; set; }

        [Display(Name = "Customer Name")]
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        //Custom Validation

        public static ValidationResult StartDateInTheFuture(DateTime? validDate, ValidationContext context) {
	            if (validDate == null) {
	                return ValidationResult.Success;
	            }
	            if (validDate > DateTime.Today) {
	                return ValidationResult.Success;
	            }
	                return new ValidationResult("Start date must be in the future");
	    }

        public static ValidationResult ExpiryDateGreaterThanStartDate(DateTime? expiryDate, ValidationContext context) {
	            if (expiryDate == null) {
	                return ValidationResult.Success;
	            }
	            var instance = context.ObjectInstance as Coupon;
	            if (expiryDate > instance.ValidDate) {
	                return ValidationResult.Success;
                }
	                return new ValidationResult("Expiry date must be greater than Start Date");
	    }
    }
}
            