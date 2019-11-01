using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Repository;
using Library.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace UI.Api
{
    [Route("api/TravelProvider")]
    [ApiController]
    public class TravelProviderController : MainController<TravelProvider, TravelProviderRepository>
    {
        public TravelProviderController(TravelProviderRepository repository):base(repository)     
        {

        }

    }
}