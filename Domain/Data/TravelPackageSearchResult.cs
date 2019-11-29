using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Data
{
   public class TravelPackageSearchResult : ITravelPackage
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public int StatusId { get; set; }
            public decimal RRP { get; set; }
            public int CityId { get; set; }
            public string City { get; set; }
            public int NumberOfDays { get; set; }

            public string Attraction { get; set; }

        
    }
}
