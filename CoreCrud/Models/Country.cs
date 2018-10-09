
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreCrud.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        
        [Display(Name = "Country Name")]
        [Required(ErrorMessage = "Please provide the country name")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "2 - 100 characters only")]
        public string Name{ get; set; }

        public ICollection<Destination> Destinations { get; set; }

        [NotMapped]

        public Destination LastDestination {
            get {
                return Destinations.OrderByDescending(x => x.TravelDate)
                                   .FirstOrDefault();
            }
        }

        [NotMapped]

        public bool IsDestinationOn {
            get {
                return LastDestination.ReturnDate == null;
            }
        }
    }
}
            