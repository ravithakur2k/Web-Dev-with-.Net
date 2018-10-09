using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace CoreCrud.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
				if(context.Destination.Any()){
					return;
				}			

				var countryIndia = new Country { Name = "India" };
                var countryUSA = new Country { Name = "USA" };
				var countryEngland = new Country { Name = "England" };
				var countryAustralia = new Country { Name = "Australia" };
                var countrySouthAfrica = new Country { Name = "South Africa" };
				
				context.Country.AddRange(
				countryIndia,
				countryUSA,
				countryEngland,
				countryAustralia,
                countrySouthAfrica
				);
				context.Destination.AddRange(
				new Destination {
					Name = "Agra",
					TravelDate = new DateTime(2018,2,1),
					isEnjoyable = true,
					CostToTravelToDestination = 2500,
					ReturnDate = new DateTime(2018,2,10),
					Country = countryIndia
					},
                new Destination {
					Name = "Bangalore",
					TravelDate = new DateTime(2015,2,1),
					isEnjoyable = true,
					CostToTravelToDestination = 1000,
					ReturnDate = new DateTime(2015,2,10),
					Country = countryIndia
					},
                new Destination {
					Name = "Mysore",
					TravelDate = new DateTime(2013,2,1),
					isEnjoyable = true,
					CostToTravelToDestination = 1000,
					ReturnDate = new DateTime(2013,2,10),
					Country = countryIndia
					},
                new Destination {
					Name = "Mumbai",
					TravelDate = new DateTime(2012,2,1),
					isEnjoyable = true,
					CostToTravelToDestination = 1200,
					ReturnDate = new DateTime(2012,2,10),
					Country = countryIndia
					},
                new Destination {
					Name = "Delhi",
					TravelDate = new DateTime(2011,2,1),
					isEnjoyable = true,
					CostToTravelToDestination = 800,
					ReturnDate = new DateTime(2011,2,10),
					Country = countryIndia
					},
                new Destination {
					Name = "Amritsar",
					TravelDate = new DateTime(2010,2,1),
					isEnjoyable = true,
					CostToTravelToDestination = 600,
					ReturnDate = new DateTime(2010,2,15),
					Country = countryIndia
					},
				new Destination {
					Name = "New York",
					TravelDate = new DateTime(2015,1,10),
					isEnjoyable = true,
					CostToTravelToDestination = 3000,
					ReturnDate = new DateTime(2015,1,25),
					Country = countryUSA
					},
                new Destination {
					Name = "Chicago",
					TravelDate = new DateTime(2016,1,10),
					isEnjoyable = true,
					CostToTravelToDestination = 2000,
					ReturnDate = new DateTime(2016,1,25),
					Country = countryUSA
					},
                new Destination {
					Name = "Florida",
					TravelDate = new DateTime(2014,3,10),
					isEnjoyable = true,
					CostToTravelToDestination = 2500,
					ReturnDate = new DateTime(2016,3,25),
					Country = countryUSA
					},
                new Destination {
					Name = "Las Vegas",
					TravelDate = new DateTime(2017,3,10),
					isEnjoyable = true,
					CostToTravelToDestination = 3500,
					ReturnDate = new DateTime(2017,3,25),
					Country = countryUSA
					},
				new Destination {
					Name = "London",
					TravelDate = new DateTime(2016,5,15),
					isEnjoyable = true,
					CostToTravelToDestination = 3500,
					ReturnDate = new DateTime(2015,5,28),
					Country = countryEngland
					},
                new Destination {
					Name = "Yorkshire",
					TravelDate = new DateTime(2016,8,15),
					isEnjoyable = true,
					CostToTravelToDestination = 3300,
					ReturnDate = new DateTime(2015,8,28),
					Country = countryEngland
					},
                new Destination {
					Name = "Yorkshire",
					TravelDate = new DateTime(2016,8,15),
					isEnjoyable = true,
					CostToTravelToDestination = 3300,
					ReturnDate = new DateTime(2015,8,28),
					Country = countryEngland
					},
                new Destination {
					Name = "Sydney",
					TravelDate = new DateTime(2017,7,13),
					isEnjoyable = true,
					CostToTravelToDestination = 2000,
					ReturnDate = new DateTime(2017,7,23),
					Country = countryAustralia
					},
                new Destination {
					Name = "Brisbane",
					TravelDate = new DateTime(2017,7,13),
					isEnjoyable = true,
					CostToTravelToDestination = 2000,
					ReturnDate = new DateTime(2017,7,23),
					Country = countryAustralia
					},                	
				new Destination {
					Name = "Gold Coast",
					TravelDate = new DateTime(2009,8,12),
					isEnjoyable = true,
					CostToTravelToDestination = 1500,
					ReturnDate = new DateTime(2009,8,23),
					Country = countryAustralia
					},
                new Destination {
					Name = "Uluru",
					TravelDate = new DateTime(2009,2,12),
					isEnjoyable = true,
					CostToTravelToDestination = 1300,
					ReturnDate = new DateTime(2009,2,23),
					Country = countryAustralia
					},
                new Destination {
					Name = "Adelaide",
					TravelDate = new DateTime(2009,1,12),
					isEnjoyable = true,
					CostToTravelToDestination = 1600,
					ReturnDate = new DateTime(2009,1,23),
					Country = countryAustralia
					},
                new Destination {
					Name = "Johannesburg",
					TravelDate = new DateTime(2007,1,12),
					isEnjoyable = true,
					CostToTravelToDestination = 1800,
					ReturnDate = new DateTime(2007,1,23),
					Country = countrySouthAfrica
					},
                new Destination {
					Name = "Hermanus",
					TravelDate = new DateTime(2017,1,12),
					isEnjoyable = true,
					CostToTravelToDestination = 1750,
					ReturnDate = new DateTime(2017,1,23),
					Country = countrySouthAfrica
					},
                new Destination {
					Name = "Oudtshoorn",
					TravelDate = new DateTime(2015,5,18),
					isEnjoyable = true,
					CostToTravelToDestination = 1750,
					ReturnDate = new DateTime(2015,5,28),
					Country = countrySouthAfrica
					},
                 new Destination {
					Name = "Sutherland",
					TravelDate = new DateTime(2011,4,15),
					isEnjoyable = true,
					CostToTravelToDestination = 1950,
					ReturnDate = new DateTime(2011,4,25),
					Country = countrySouthAfrica
					},
                 new Destination {
					Name = "Durban",
					TravelDate = new DateTime(2009,5,18),
					isEnjoyable = true,
					CostToTravelToDestination = 1550,
					ReturnDate = new DateTime(2009,5,28),
					Country = countrySouthAfrica
					}
				);
					context.SaveChanges();
            }
        }
    }
}