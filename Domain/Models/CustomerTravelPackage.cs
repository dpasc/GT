using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models.Models
{
    public class CustomerTravelPackage : IEntity
    {
        public CustomerTravelPackage()
        {
            Payments = new List<Payment>();
        }
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int TravelPackageId { get; set; }
        public TravelPackage TravelPackage { get; set; }
        public DateTime StartDate { get; set; }
        public decimal SalePrice { get; set; }
        public string Feedback { get; set; }

        public int VoucherId { get; set; }
        public Voucher Voucher { get; set; }
        public List<Payment> Payments { get; set; }
    }
}
