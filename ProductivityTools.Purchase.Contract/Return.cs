using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Purchase.Contract
{
    public class Return
    {
        public string Id { get; set; }
        public List<PurchaseItem> Items { get; set; }

        public Return()
        {
            this.Items = new List<PurchaseItem>();
        }
    }
}
