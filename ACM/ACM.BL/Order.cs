using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Order:EntityBase
    {
        public Order() : this(0)
        {
        }

        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }

        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int ShippingAddress { get; set; }

        public override string ToString()
        {
            return $"{OrderDate.Value.Date} ({OrderId})";
        }

        public override bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;
            return isValid;
        }
    }
}