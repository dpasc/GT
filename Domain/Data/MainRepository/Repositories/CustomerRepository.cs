using Library.Models;
using Library.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Data.MainRepository.Repositories
{
    public class CustomerRepository :MainRepository<Customer,GTContext>
    {
        public CustomerRepository(GTContext context):base(context)
        {

        }
    }
}
