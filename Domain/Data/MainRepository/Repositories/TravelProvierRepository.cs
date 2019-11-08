using Library.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Data.MainRepository.Repositories
{
    class TravelProvierRepository:MainRepository<TravelProvider,GTContext>
    {
        public TravelProvierRepository(GTContext context):base(context)
        {

        }




    }
}
