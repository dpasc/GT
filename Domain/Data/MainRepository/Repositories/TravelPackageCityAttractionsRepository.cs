using Library.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Data.MainRepository.Repositories
{
    public class TravelPackageCityAttractionsRepository:MainRepository<TravelPackageCityAttraction,GTContext>
    {

        public TravelPackageCityAttractionsRepository(GTContext context):base(context)
        {

        }

    }
}
