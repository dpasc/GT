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



    }
}
