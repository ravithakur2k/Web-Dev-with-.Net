using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace CouponManagement.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                // if(context.Coupons.Any()){
				// 	return;
				// }

                // var Category1 = new CouponCategory { Name  = "Movie"};
                // var Category2 = new CouponCategory { Name  = "Food"};
                // var Category3 = new CouponCategory { Name  = "Health Care"};
                // var Category4 = new CouponCategory { Name  = "Electronics"};
                // var Category5 = new CouponCategory { Name  = "Apparels"};

                // var Seller1 = new Seller { Name  = "Ravi Thakur"};
                // var Seller2 = new Seller { Name  = "Syed"};
                // var Seller3 = new Seller { Name  = "Jaimin Parekh"};
                // var Seller4 = new Seller { Name  = "Arijit Bhatt"};
                // var Seller5 = new Seller { Name  = "Abhishek"};

                // var Customer1 = new Customer { FirstName  = "Bhavya"};
                // var Customer2 = new Customer { FirstName  = "Manish"};
                // var Customer3 = new Customer { FirstName  = "Luke"};
                // var Customer4 = new Customer { FirstName  = "Rashi"};
                // var Customer5 = new Customer { FirstName  = "Mukesh"};


                // context.CouponCategories.AddRange(
                //     new CouponCategory
                //     {
                //         Name  = "Movie",
                //         Description="Enjoy culinary delights with discounts"
                //     },
                //     new CouponCategory
                //     {
                //         Name  = "Food",
                //         Description="Enjoy your favorite flick"
                //     },
                //     new CouponCategory
                //     {
                //         Name  = "Health Care",
                //         Description="Affordable health care benefits with coupons"
                //     },
                //     new CouponCategory
                //     {
                //         Name  = "Electronics",
                //         Description="Your favourite gadgets are a dollar away"
                //     },
                //     new CouponCategory
                //     {
                //         Name  = "Apparels",
                //         Description="Enabling value for money fashion"
                //     }
                // );
                //     context.Sellers.AddRange(
                //     new Seller
                //     {
                //         Name  = "Ravi Thakur",
                //         Address="3239 Bishop Street",
                //         Email = "ravi.thakur11@gmail.com",
                //         PhoneNumber = 5132880920,
                //     },
                //     new Seller
                //     {
                //         Name  = "Syed",
                //         Address="3265 Bishop Street",
                //         Email = "syed.rehman@gmail.com",
                //         PhoneNumber = 5132880932,
                //     },
                //     new Seller
                //     {
                //         Name  = "Jaimin Parekh",
                //         Address="Forum Apartments",
                //         Email = "jaimin.parekh@gmail.com",
                //         PhoneNumber = 5134179255,
                //     },
                //     new Seller
                //     {
                //         Name  = "Arijit Bhatt",
                //         Address="Forum Apartments",
                //         Email = "arijit.bhatt@gmail.com",
                //         PhoneNumber = 5134862233,
                //     },
                //     new Seller
                //     {
                //         Name  = "Abhishek",
                //         Address="Forum Apartments",
                //         Email = "abhishek@gmail.com",
                //         PhoneNumber = 5134862453,
                //     }

                // );

                // context.Customers.AddRange(
                //     new Customer
                //     {
                //         FirstName = "Bhavya",
                //         LastName = "Bansal",
                //         StreetAddress = "707 Martin Luther King Dr W, Cincinnati, Ohio",
                //         ZipCode = 45220,
                //         Email = "bbansal@abc.com",
                //         PhoneNumber = 5134226786,

                //     },
                //      new Customer
                //     {
                //         FirstName = "Manish",
                //         LastName = "Semwal",
                //         StreetAddress = "707 Martin Luther King Dr W, Cincinnati, Ohio",
                //         ZipCode = 45220,
                //         Email = "msemwal@msenp.com",
                //         PhoneNumber = 5434226386,
                //     },
                //      new Customer
                //     {
                //         FirstName = "Luke",
                //         LastName = "Basler",
                //         StreetAddress = "70 Bishop Street, Cincinnati, Ohio",
                //         ZipCode = 45220,
                //         Email = "bbasler@bslrinc.com",
                //         PhoneNumber = 5264538888,
                //     },
                //      new Customer
                //     {
                //         FirstName = "Rashi",
                //         LastName = "Sharma",
                //         StreetAddress = "707 Martin Luther King Dr W, Cincinnati, Ohio",
                //         ZipCode = 45220,
                //         Email = "rsharma@comtec.com",
                //         PhoneNumber = 5134272352,
                //     },
                //      new Customer
                //     {
                //         FirstName = "Mukesh",
                //         LastName = "Harana",
                //         StreetAddress = "324, Ludlow, Cincinnati, Ohio",
                //         ZipCode = 45220,
                //         Email = "Mharana@tbfree.com",
                //         PhoneNumber = 5137865132,
                //     }                   
                // );

                // context.Coupons.AddRange(
                //     new Coupon
                //     {
                //         Name = "AmeX 20% Off",
                //         ValidDate = new DateTime(11/10/2018),
                //         ExpiryDate = new DateTime(11/11/2020),
                //         Price = 7,
                //         Rating = 3,
                //         CategoryId = 1,
                //         SellerId = 2,
                //         CustomerId = 3,
                //     },  
                //     new Coupon
                //     {
                //         Name = "Hungry40",
                //         ValidDate = new DateTime(01/01/2019),
                //         ExpiryDate = new DateTime(03/13/2019),
                //         Price = 5,
                //         Rating = 4,
                //         CategoryId = 2,
                //         SellerId = 3,
                //         CustomerId = 5,
                //     },         
                //     new Coupon
                //     {
                //         Name = "WalGreens 30% Off",
                //         ValidDate = new DateTime(05/10/2019),
                //         ExpiryDate = new DateTime(11/11/2022),
                //         Price = 9,
                //         Rating = 5,
                //         CategoryId = 3,
                //         SellerId = 5,
                //         CustomerId = 5,
                //     }, 
                //     new Coupon
                //     {
                //         Name = "Gadget Bonanza 50% Off",
                //         ValidDate = new DateTime(11/15/2018),
                //         ExpiryDate = new DateTime(11/15/2023),
                //         Price = 10,
                //         Rating = 5,
                //         CategoryId = 4,
                //         SellerId = 1,
                //         CustomerId = 5,
                //     },  
                //     new Coupon
                //     {
                //         Name = "Fashion sale 30%",
                //         ValidDate = new DateTime(09/01/2020),
                //         ExpiryDate = new DateTime(10/01/2022),
                //         Price = 5,
                //         Rating = 3,
                //         CategoryId = 5,
                //         SellerId = 2,
                //         CustomerId = 3,
                //     }
                // );

                // var customer1 = new Customer { FirstName  = "Ravi", LastName = "Thakur"};
                // var customer2 = new Customer { Name  = "Jaimin Parekh"};
                // var customer3 = new Customer { Name  = "Ravi Thakur"};
                // var customer4 = new Customer { Name  = "Ravi Thakur"};
                // var customer5 = new Customer { Name  = "Ravi Thakur"};
               
                // GATTUSMP: SAMPLE OF A SEED FILE THAT FIRST LOOKS FOR A DATABASE WITH DATA
                //           IF NO DATA FOUND THEN DATA IS ADDED TO THE DATABASE
                // // Look for any movies.
                // if (context.Movie.Any())
                // {
                //     return;   // DB has been seeded
                // }

                // context.Movie.AddRange(
                //     new Movie
                //     {
                //         Title = "When Harry Met Sally",
                //         ReleaseDate = DateTime.Parse("1989-2-12"),
                //         Genre = "Romantic Comedy",
                //         Price = 7.99M
                //     },

                //     new Movie
                //     {
                //         Title = "Ghostbusters",
                //         ReleaseDate = DateTime.Parse("1984-3-13"),
                //         Genre = "Comedy",
                //         Price = 8.99M
                //     },

                //     new Movie
                //     {
                //         Title = "Ghostbusters 2",
                //         ReleaseDate = DateTime.Parse("1986-2-23"),
                //         Genre = "Comedy",
                //         Price = 9.99M
                //     },

                //     new Movie
                //     {
                //         Title = "Rio Bravo",
                //         ReleaseDate = DateTime.Parse("1959-4-15"),
                //         Genre = "Western",
                //         Price = 3.99M
                //     }
                // );
                context.SaveChanges();
            }
        }
    }
}