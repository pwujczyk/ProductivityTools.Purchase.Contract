using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Purchase.Contract
{
    public class Payment
    {
        public DateTime Date { get; set; }
        public decimal? Amount { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
    }
}
