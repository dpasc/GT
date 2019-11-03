
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models.Models
{
    public class CityAttraction :IEntity
    {
        public CityAttraction()

        {

            TravelPackageCityAttractions = new List<TravelPackageCityAttraction>();

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }

        public List<TravelPackageCityAttraction> TravelPackageCityAttractions { get; set; }
    }
}
