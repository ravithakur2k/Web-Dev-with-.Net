
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CouponManagement.Models
{
    public class AnalysisForm
    {
        [Key]
        public int Id { get; set; }

        public AnalysisForm() {
            
        }
        
        [Display(Name="Customer")]
        [Required(ErrorMessage = "Please select a customer")]
        [CustomValidation(typeof(AnalysisForm), "ValidateCustomer")]
        public int CustomerId { get; set; }

        public static ValidationResult ValidateCustomer(int? customerId, ValidationContext context) {
            if (customerId == null) {
                return ValidationResult.Success;
            }
            var dbContext = context.GetService(typeof(AppDbContext)) as AppDbContext;
            var customer = dbContext.Customers
                                         .FirstOrDefault(x => x.Id == customerId.Value);
            if (customer == null) {
                return new ValidationResult("Please select a valid Customer");
            }
            return ValidationResult.Success;
        }
    }
}