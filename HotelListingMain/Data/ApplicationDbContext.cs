using Microsoft.EntityFrameworkCore;
using System;

namespace HotelListingMain.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }


        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel>Hotels { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                
                new Country()
                {
                    Id = 1,
                    Name = "Jamaica",
                    ShortName = "JM"
                },
                new Country()
                {
                    Id = 2,
                    Name = "Bahamas",
                    ShortName = "BH"
                },
                new Country()
                {
                    Id = 3,
                    Name = "Canada",
                    ShortName = "CA"
                }

            );

            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "GrandBanksHotel",
                    Address = "The belss junction",
                    CountryId = 1,
                    Rating = 4.6
                },
                new Hotel()
                {
                    Id = 2,
                    Name = "Heritage Hotel",
                    Address = "Iju",
                    CountryId = 2,
                    Rating = 6.6
                },
                new Hotel()
                {
                    Id = 3,
                    Name = "City-Link Hotel",
                    Address = "Suleja, Niger state",
                    CountryId = 3,
                    Rating = 8.6
                }

            ); ;
        }

        //public static implicit operator ApplicationDbContext(DbSet<T> v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
