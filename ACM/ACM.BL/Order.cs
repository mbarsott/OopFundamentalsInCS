using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public DateTime OrderDate { get; set; }

        public bool Validate()
        {
            return true;
        }

        public Order Retrieve()
        {
            return new Order();
        }

        public void Save()
        {

        }
    }
}
