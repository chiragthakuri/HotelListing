using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {}

        

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Canada",
                    ShortName = "CA"
                },
                new Country
                {
                    Id = 2,
                    Name = "USA",
                    ShortName = "US"
                },
                new Country
                {
                    Id = 3,
                    Name = "Denmark",
                    ShortName = "DK"
                }

             );

            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Sandman Hotel",
                    Address = "St james",
                    CountryId = 1,
                    Rating = 4.1
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Radisson Hotel",
                    Address = "Florida",
                    CountryId = 2,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Denmark Hotel",
                    Address = "DK Strest",
                    CountryId = 3,
                    Rating = 4.0
                }

             );
        }
    }
}
