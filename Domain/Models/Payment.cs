﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models.Models
{
    public class Payment :IEntity
    {
        public int Id { get; set; }
        public int CustomerTravelPackageId { get; set; }
        public CustomerTravelPackage CustomerTravelPackage { get; set; }
        public DateTime DateTime { get; set; }
        public decimal Amount { get; set; }
    }
}
