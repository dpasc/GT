using Library.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data.MainRepository.Repositories
{
    public class TravelPackageCityRepository : MainRepository<TravelPackageCity, GTContext>
    {
        public TravelPackageCityRepository(GTContext context) : base(context)
        {

        }


        public async Task<TravelPackageCity> AddTPC( int travelPackageId, int cityId, int numberofDays)
        {
            var tpc = new TravelPackageCity()
            {
                TravelPackageId = travelPackageId,
                CityId = cityId,
                NumberOfDays = numberofDays
            };
            context.Set<TravelPackageCity>().Add(tpc);
            await context.SaveChangesAsync();
            return tpc;

        }

    }

}
