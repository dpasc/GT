using Domain.Data;
using Library.Models;
using Library.Models.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public class TravelProviderRepository : EfRepository<TravelProvider, GTContext>

    {
        public TravelProviderRepository(GTContext context) : base(context)
        {

        }
 

    }

}
