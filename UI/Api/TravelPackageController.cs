using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace UI.Api
{
    [Route("api/travelpackage")]
    [ApiController]
    public class TravelPackageController : ControllerBase
    {
        private readonly GTContext _gtContext;

        public TravelPackageController(GTContext gTContext)
        {
            _gtContext = gTContext;
        }

        [HttpGet]
        public List<object> Get()
        {
            var result = _gtContext.TravelPackages
                .Include(tp => tp.Cities)
                    .ThenInclude(tpc => tpc.City)
                .Include(tp => tp.Cities)
                    .ThenInclude(tpc => tpc.TravelPackageCityAttractions)
                    .ThenInclude(tpca => tpca.CityAttraction)
                .Select(tp => new
                {
                    tp.Id,
                    tp.Name,
                    Price = tp.RRP,
                    Cities = tp.Cities.Select(tpc => new {
                        tpc.City.Name,
                        tpc.NumberOfDays,
                        Attractions = tpc.TravelPackageCityAttractions.Select(tpca => new {
                            tpca.CityAttraction.Name,
                            tpca.CityAttraction.Description
                        })
                    })
                })
                .ToList<object>();

            return result;

        }

    }
}
