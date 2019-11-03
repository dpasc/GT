using Library.Models;
using Library.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data.MainRepository.Repositories
{
    public class TravelProviderRepository : MainRepository<TravelProvider, GTContext>
    {
        public TravelProviderRepository(GTContext context):base(context)
        {

        }

        public async Task<List<TravelProvider>> SeekAll()
        {
            return await context.Set<TravelProvider>().ToListAsync();
        }

        public async Task<TravelProvider> AddTP(TravelProvider entity)
        {
            context.Set<TravelProvider>().Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }
    }
}
