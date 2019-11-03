﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models.Models
{
    public class Customer :Person 
    {
        public Customer()
        {
            TravelPackages = new List<CustomerTravelPackage>();
            Vouchers = new List<Voucher>();
        }

        public List<CustomerTravelPackage> TravelPackages { get; set; }
        public List<Voucher> Vouchers { get; set; }

    }
}
