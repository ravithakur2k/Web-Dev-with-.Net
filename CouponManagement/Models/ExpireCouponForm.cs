
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CouponManagement.Models
{
    public class ExpireCouponForm
    {  
        public ExpireCouponForm() {
            ExpiryDate = DateTime.Today;
        }
        public int CouponId { get; set; }
        
        // UPDATE RETIREMENT DATE WITH BETTER TEXT, VALIDATION, AND INPUT
        [Display(Name="Expiry Date")]
        [DataType(DataType.Date)]
        public DateTime ExpiryDate { get; set; }
    }
}
           