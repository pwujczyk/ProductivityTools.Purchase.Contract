using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Purchases.Contract
{
    public class Delivery
    {
        public DateTime Date { get; set; }
        public string Number { get; set; }
        public string Status { get; set; }
    }
}
