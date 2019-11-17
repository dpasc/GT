using Library.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Data.MainRepository.Repositories
{
    public class PaymentRepository : MainRepository<Payment, GTContext>
    {
        public PaymentRepository(GTContext context):base(context)
        {

        }


        //ToDo ProcessPayment method (CustomerTravelPackage, some form of payment type and code to match)


    }
}
