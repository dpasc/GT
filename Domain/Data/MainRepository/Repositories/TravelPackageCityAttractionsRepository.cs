using Library.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data.MainRepository.Repositories
{
    public class TravelPackageCityAttractionsRepository:MainRepository<TravelPackageCityAttraction,GTContext>
    {
        
        public TravelPackageCityAttractionsRepository(GTContext context):base(context)
        {

        }

        public async Task<List<TravelPackageCityAttraction>> GetListForTPC(int tpcId)
        {
            return await context.Set<TravelPackageCityAttraction>()
                 .Where(tpca => tpca.TravelPackageCityId == tpcId)
                 .Include(tpca => tpca.CityAttraction)
                 .Include(tpca => tpca.TravelPackageCity.City)    
                .ToListAsync();
        }

        public async Task<List<CityAttraction>> GetListForOfCAForIndex(int id)
        {
  
            var currentTPC = context.TravelPackageCities
                .SingleOrDefault(tpc => tpc.Id == id);

            var listOfCa = context.CityAttractions
                .Where(ca => ca.CityId == currentTPC.CityId);

            return await listOfCa.ToListAsync();
        }





    }
}
