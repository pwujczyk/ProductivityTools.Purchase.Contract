using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Purchases.Contract
{
    public class Purchase
    {
        public int Id { get; set; }
        public string ShopName { get; set; }
        public string ExternalSystemId { get; set; }
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
            this.ExternalSystemId = id;
            this.Dealer = new Dealer();
            this.Payment = new Payment();
            this.Items = new List<PurchaseItem>();
            this.Delivery = new List<Delivery>();
        }
    }
}
