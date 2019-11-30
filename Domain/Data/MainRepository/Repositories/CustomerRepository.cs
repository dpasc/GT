using Domain.Models;
using Library.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data.MainRepository.Repositories
{
    public class CustomerRepository : MainRepository<Customer, GTContext>
    {
        public CustomerRepository(GTContext context) : base(context)
        {

        }

        public TravelPackage GetTP(int id)
        {
            return  context.Set<TravelPackage>()
             .FirstOrDefault(entity => entity.Id == id);
        }

        public IEnumerable<CustomerTravelPackage> GetAllOfCustomersTravelPackages(int customerId)
        {
            var list = context.Set<CustomerTravelPackage>()
            
                .Where(ctp => ctp.CustomerId == customerId)
                .ToList();
            return  list;
        }

        //Add this method to the main controller and allow other classes to
        //override if need be 
        public async Task<Person> GetCustomerByUserId(string userId)
        {
            var person = await context.Set<Person>()
                .FirstOrDefaultAsync(p => p.UserId == userId);
            return person;

        }



    }
}
