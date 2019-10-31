using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models.Models
{
    public class BitcoinPayment: Payment 
    {
        public string TransactionHashcode { get; set; }
    }
}
