using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Data;
using Domain.Data.MainRepository.Repositories;
using Library.Models.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace UI.Api
{
    [Route("api/travelpackage")]
    [ApiController]
    public class TravelPackageController : ControllerBase
    {
        private readonly TravelPackageRepository _tpr;

        public TravelPackageController(TravelPackageRepository tpr)
        {
            _tpr = tpr;
        }

        [HttpGet]
        public IList<object> GetByLocation(string city)
        {
            return _tpr.GetAllViaLocationApi(city);
        }

       


    }
}
