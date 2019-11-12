using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models.Models
{
    public class TravelPackageCityAttraction:IEntity
    {
        public int Id { get; set; }
        public int TravelPackageCityId { get; set; }
        public TravelPackageCity TravelPackageCity { get; set; }
        public int CityAttractionId { get; set; }
        public CityAttraction CityAttraction { get; set; }



    }
}
