using Library.Models;
using Library.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repository
{
    public class TravelProviderRepository: EfRepository<TravelProvider, GTContext>
    {
        public TravelProviderRepository(GTContext context):base(context)
        {

        }
    }
}
