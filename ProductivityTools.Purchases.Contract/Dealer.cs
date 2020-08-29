using System;

namespace ProductivityTools.Purchases.Contract
{
    public class Dealer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public int PurchaseId { get; set; }
        public Purchase Purchase { get; set; }

    }
}
