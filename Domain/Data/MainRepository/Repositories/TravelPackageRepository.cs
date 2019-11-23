using Library.Models.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data.MainRepository.Repositories
{
    public class TravelPackageRepository: MainRepository<TravelPackage,GTContext>
    {
        public TravelPackageRepository(GTContext context):base(context)
        {

        }

        //Get all for api
        public List<object> GetAllForApi()
        {
            var result = context.TravelPackages
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
            Cities = tp.Cities.Select(tpc => new
            {
                tpc.City.Name,
                tpc.NumberOfDays,
                Attractions = tpc.TravelPackageCityAttractions.Select(tpca => new
                {
                    tpca.CityAttraction.Name,
                    tpca.CityAttraction.Description
                })
            })
        })
         .ToList<object>();
            return result;
        }


        //Get by location for api using stored procedure 
        public IList<object> GetAllViaLocationApi(string city)
        {
            (string, object)[] parameters = { ("@city", city), ("@name", null), ("@description", null), ("@skip", 0), ("@take", 100), ("@orderby", "Name"), ("@orderDirection", "DESC") };
            var cmd = context.LoadStoredProcedure("spSearchTravelPackages");
            cmd.WithSqlParams(parameters);
            var result = cmd.ExecuteStoredProcedure<TravelPackageSearchResult>().GroupBy(r => r.Name).ToList<object>();
            return result;    
        }





    }
}
