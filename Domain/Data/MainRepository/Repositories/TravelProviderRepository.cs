using Library.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data.MainRepository.Repositories
{
    public class TravelProviderRepository:MainRepository<TravelProvider,GTContext>
    {
        public TravelProviderRepository(GTContext context):base(context)
        {

        }

        public async override Task<TravelProvider>Get(int? id)
        {
            return await context.Set<TravelProvider>().FindAsync(id);
        }

        public async override Task<List<TravelProvider>>GetAll()
        {
            return await context.Set<TravelProvider>().ToListAsync();
        }

        


    }
}
