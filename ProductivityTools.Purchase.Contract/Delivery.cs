using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Purchase.Contract
{
    public class Delivery
    {
        public DateTime DeliveryDate { get; set; }
        public string DeliveryNumber { get; set; }
        public string DeliveryStatus { get; set; }
    }
}
