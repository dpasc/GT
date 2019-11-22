using System.Collections.Generic;
using Library.Models.Models;

namespace UI.Api
{
   public class TravelPackage2
    {
        public TravelPackage2()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<TravelPackageCity> Locations { get; set; }
    }
}