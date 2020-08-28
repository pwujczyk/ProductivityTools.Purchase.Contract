using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Purchases.Contract
{
    public class Purchase
    {
        public string Id { get; set; }
        public string DeliveryAddress { get; set; }
        public string ReceipmentPhone { get; set; }
        public string Status { get; set; }
        public string ReturnNumber { get; set; }
        public List<PurchaseItem> Items { get; set; }
        public Dealer Dealer { get; set; }
        public Payment Payment { get; set; }
        public List<Delivery> Delivery { get; set; }

        public Purchase() { }

        public Purchase(string id) : this()
        {
            this.Id = id;
            this.Dealer = new Dealer();
            this.Payment = new Payment();
            this.Delivery = new List<Delivery>();
        }
    }
}
