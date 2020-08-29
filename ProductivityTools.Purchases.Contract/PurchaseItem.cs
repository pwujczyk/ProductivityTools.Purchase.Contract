using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Purchases.Contract
{
    public class PurchaseItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal SinglePrice { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }

        public int? ReturnedAmount { get; set; }
        public decimal ReturnedPrice { get; set; }

        public decimal TotalPrice
        {
            get
            {
                return SinglePrice * Amount;
            }
        }

        public decimal TotalCost
        {
            get
            {
                if (ReturnedAmount.HasValue)
                {
                    var cost = this.TotalPrice - (Amount * ReturnedAmount.Value);
                    return cost;
                }
                else
                {
                    return this.TotalPrice;
                }
            }
        }
    }   
}
