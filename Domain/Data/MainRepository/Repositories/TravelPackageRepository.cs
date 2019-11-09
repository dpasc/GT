using Library.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data.MainRepository.Repositories
{
    public class TravelPackageRepository: MainRepository<TravelPackage,GTContext>
    {
        public TravelPackageRepository(GTContext context):base(context)
        {

        }






    }
}
