using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models.Models
{
    public class PayPalPayment : Payment
    {
        public string RecordOfCharge { get; set; }
    }
}
