using Library.Models;
using Library.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data.MainRepository.Repositories
{
    public class PersonRepository :MainRepository<Customer,GTContext>
    {
        public PersonRepository(GTContext context):base(context)
        {

        }
        //TODO: Fix Method
        //Create customer 
        public async Task<Customer> AddCustomer(string forename, string surname)
        {
            var customer = new Customer()
            {
       
                Forename = forename,
                Surname = surname,
            
            };
            context.People.Add(customer);
            await context.SaveChangesAsync();
            return customer;
        }

        //Create staff memeber
    }
}
