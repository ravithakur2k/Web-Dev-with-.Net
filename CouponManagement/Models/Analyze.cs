
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CouponManagement.Models
{
    public class Analyze
    {
        public Analyze() {
            AnalysisDate = DateTime.Today;
        }
        
        [Key]
        public int Id { get; set; }
        
        public int CustomerId { get; set; }

        public DateTime AnalysisDate { get; set; }
    }
}