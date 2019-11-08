using Library.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data.MainRepository.Repositories
{
    public class TravelPackagesRepository: MainRepository<TravelPackage,GTContext>
    {
        public TravelPackagesRepository(GTContext context):base(context)
        {

        }






    }
}
