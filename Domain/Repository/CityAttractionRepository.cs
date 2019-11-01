using Library.Models;
using Library.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repository
{
    public class CityAttractionRepository : EfRepository<CityAttraction,GTContext>
    {
        public CityAttractionRepository(GTContext context):base(context)
        {

        }
    }
}
