using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models.Models
{
    public class TravelPackageCity:IEntity
    {
        public TravelPackageCity()
        {
            TravelPackageCityAttractions = new List<TravelPackageCityAttraction>();
        }

        public int Id { get; set; }

        public int TravelPackageId { get; set; }
        public TravelPackage TravelPackage { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public int NumberOfDays { get; set; }
        public List<TravelPackageCityAttraction> TravelPackageCityAttractions { get; set; }



        public TravelPackageCityAttraction AddAttraction(CityAttraction attraction)
        {
            var tpca = new TravelPackageCityAttraction
            {
                CityAttraction = attraction,
                TravelPackageCity = this
            };
            TravelPackageCityAttractions.Add(tpca);
            return tpca;

        }
    }
}
