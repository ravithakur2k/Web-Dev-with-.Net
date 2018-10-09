
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreCrud.Models
{
    public class Destination
    {
        [Key]
        public int Id { get; set; }

        
        [Display(Name = "Destination Name")]
        [Required(ErrorMessage = "Please provide the destination name")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "2 - 100 characters only")]         
        public string Name { get; set;}

        [Display(Name = "Travel Date")]
        [Required(ErrorMessage = "Please provide the date of travel")]
        [DataType(DataType.Date)]
        [CustomValidation(typeof(Destination), "TravelDateInTheFuture")]
        public DateTime TravelDate { get; set;}

        [Display(Name = "Was Destination Enjoyable? True | False")]
        public bool? isEnjoyable { get; set;}

        [Display(Name = "Estimated Cost to Destination ")]
        [Required(ErrorMessage = "Please provide the estimated cost to destination")]
        [Range(100, 10000, ErrorMessage = "Between 100 - 10000 dollars only")]
        [DataType(DataType.Currency)]
        public decimal CostToTravelToDestination { get; set; }

        [Display(Name = "Return Date")]
        [Required(ErrorMessage = "Please provide the date of return")]
        [DataType(DataType.Date)]
        [CustomValidation(typeof(Destination), "ReturnDateGreaterThanTravelDate")]
        public DateTime ReturnDate { get; set; }

        [Display(Name = "Country")]
        public int CountryId { get; set; }

        public Country Country { get; set; }

        public static ValidationResult TravelDateInTheFuture(DateTime? travelDate, ValidationContext context) {
            if (travelDate == null) {
                return ValidationResult.Success;
            }
            if (travelDate > DateTime.Today) {
                return ValidationResult.Success;
            }
                return new ValidationResult("Travel date must be in the future");
        }

         public static ValidationResult ReturnDateGreaterThanTravelDate(DateTime? returnDate, ValidationContext context) {
            if (returnDate == null) {
                return ValidationResult.Success;
            }
            var instance = context.ObjectInstance as Destination;
            if (returnDate > instance.TravelDate) {
                return ValidationResult.Success;
            }
                return new ValidationResult("Return date must be greater than Travel Date");
        }

        

    }
    
}
            