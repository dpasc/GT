using Library.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data.MainRepository.Repositories
{
    public class CustomerTravelPackageRepository :MainRepository<CustomerTravelPackage, GTContext>
    {
        public CustomerTravelPackageRepository(GTContext context):base(context)
        {

        }

        public async Task<Person> GetCustomerByUserId(string userId)
        {
            var person  = await context.Set<Person>()
                .FirstOrDefaultAsync(p => p.UserId == userId);
            return person;
            

        }

        //public async Task<CustomerTravelPackage> Create(Customer customer, TravelPackage travelPackage)
        //{
        //    reutrn 
        //}


    }
}
