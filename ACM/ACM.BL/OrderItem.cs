using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }

        public bool Validate()
        {
            return true;
        }

        public OrderItem Retrieve()
        {
            return new OrderItem();
        }

        public void Save()
        {

        }
    }
}
