using Library.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class RepoContext :DbContext
    {

        public RepoContext(DbContextOptions<RepoContext> options):base(options)
        {

        }

        public DbSet<City> Cities { get; set; }
        public DbSet<CityAttraction> CityAttractions { get; set; }
        public DbSet<CustomerTravelPackage> CustomerTravelPackages { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<TravelPackage> TravelPackages { get; set; }
        public DbSet<TravelPackageCity> TravelPackageCities { get; set; }
        public DbSet<TravelPackageCityAttraction> TravelPackageCityAttractions { get; set; }
        public DbSet<TravelProvider> TravelProviders { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
    }
}
