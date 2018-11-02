
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CouponManagement.Models
{
    public class CouponCategory
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Category Name")]
        [Required(ErrorMessage = "Please provide the category name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage ="3 - 50 characters only")]
        [CustomValidation(typeof(CouponCategory), "NameValidation")]
        public string Name{ get; set; }

        [Display(Name = "Category Description")]
        [Required(ErrorMessage = "Please provide a small description")]
        [StringLength(150, MinimumLength = 5, ErrorMessage =" 5 - 150 characters only")]
        public string Description{ get; set; }
        public ICollection<Coupon> Coupons{ get; set; }


    public static ValidationResult NameValidation(string name, ValidationContext context) {
        if (string.IsNullOrWhiteSpace(name)) {
            return ValidationResult.Success;
        }
        var instance = context.ObjectInstance as CouponCategory;
        if (instance == null) {
            return ValidationResult.Success;
        }
        // GET THE DATABASE
        var dbContext = context.GetService(typeof(AppDbContext)) as AppDbContext;
        // WE NEED INCLUDE THE ID IN THE QUERY SO THAT IF WE ARE EDITING A CATEGORY 
        // WE DO NOT FIND THE CURRENT CATEGORY AND ACCIDENTLY CALL IT A DUPLICATE
        int duplicateCount = dbContext.CouponCategories
                                      .Count(x => x.Id != instance.Id && x.Name == name);
        if (duplicateCount > 0) {
            return new ValidationResult($"Name {name} already exists");
        }
        return ValidationResult.Success;
    }

        public static implicit operator int(CouponCategory v)
        {
            throw new NotImplementedException();
        }
    }
}
            