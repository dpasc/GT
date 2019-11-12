using Library.Models;
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
    public class CityAttractionsRepository :MainRepository<CityAttraction, GTContext>
    {
        public CityAttractionsRepository(GTContext context):base(context)
        {

        }

        public override async Task<List<CityAttraction>> GetAll()
        {
            return await context.Set<CityAttraction>()
                .Include(c => c.City)
                .ToListAsync();
        }

        public async Task<List<CityAttraction>> GetAllWithCityId(int? id)
        {
          return await  context.Set<CityAttraction>()
                .Include(c => c.City)
                .Where(c => c.City.Id == id)
                .ToListAsync();
        }


        public async Task<CityAttraction> GetCA(int? id)
        {
            id = 9;
            return await context.Set<CityAttraction>()
                .FirstOrDefaultAsync(ca => ca.Id == id);
                
        }


        public override async Task<CityAttraction> Add(CityAttraction entity)
        {
            context.Set<CityAttraction>().Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }






    }
}
