using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models.Models
{
    public class Employee :Person
    {
        public int TravelProviderId { get; set; }
        public TravelProvider TravelProvider { get; set; }


    }
}
