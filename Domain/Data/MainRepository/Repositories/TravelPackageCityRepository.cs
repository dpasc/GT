using Library.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data.MainRepository.Repositories
{
    public class TravelPackageCityRepository : MainRepository<TravelPackageCity, GTContext>
    {
        public TravelPackageCityRepository(GTContext context) : base(context)
        {

        }


        //public async Task<TravelPackageCity> Add( int travelPackageId, int cityId, int numberofDays)
        //{
        //    var tpc = new TravelPackageCity()
        //    {
        //        TravelPackageId = travelPackageId,
        //        CityId = cityId,
        //        NumberOfDays = numberofDays
        //    };
        //    context.Set<TravelPackageCity>().Add(tpc);
        //    await context.SaveChangesAsync();
        //    return tpc;

        //}


        public async override Task<List<TravelPackageCity>> GetAll()
        {
            return await context.Set<TravelPackageCity>()
                .Include(tpc => tpc.City)
                .Include(tpc => tpc.TravelPackage)
                .ToListAsync();
        }

        public async Task<List<TravelPackageCity>> GetAllInTP(int tpId)
        {
            return await context.Set<TravelPackageCity>()
                .Where(tpc => tpc.TravelPackageId == tpId)
                .Include(tpc => tpc.City)
                .Include(tpc => tpc.TravelPackage)
               .ToListAsync();
        }




    }
    
}
