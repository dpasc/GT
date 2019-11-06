﻿using Library.Models;
using Library.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data.MainRepository.Repositories
{
    public class CityAttractionsRepository :MainRepository<CityAttraction, GTContext>
    {
        public CityAttractionsRepository(GTContext context):base(context)
        {

        }

        public async Task<CityAttraction> AddCA(CityAttraction entity)
        {
            context.Set<CityAttraction>().Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }


    }
}