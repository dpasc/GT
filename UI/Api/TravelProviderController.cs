using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Data.MainRepository.Repositories;
using Library.Models.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UI.Api
{
    [Route("api/TravelProvider")]
    [ApiController]
    public class TravelProviderController : MainController<TravelProvider,TravelProviderRepository>
    {
        public TravelProviderController(TravelProviderRepository repository):base(repository)
        {

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TravelProvider>>> GetTP()
        {
            return await repository.SeekAll();
        }

    }
}