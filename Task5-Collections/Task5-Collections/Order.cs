using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_Collections
{
    public enum OrderStatus
    {
        Canceled,
        Received,
        Delivered
    }

    public class Order
    {
        public HashSet<Product> Products { get; set; }
        public DateTimeOffset PlacedDateTimeOffset { get; set; }
        public DateTime ExpectedDeliveryDateTime { get; set; }
        public DateTime? ActualDeliveryDateTime { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public Order(HashSet<Product> products, DateTimeOffset placedDateTimeOffset, 
            DateTime expectedDeliveryDateTime, DateTime actualDeliveryDateTime, OrderStatus orderStatus)
        { 
            Products = products;
            PlacedDateTimeOffset = placedDateTimeOffset;
            ExpectedDeliveryDateTime = expectedDeliveryDateTime;
            ActualDeliveryDateTime = actualDeliveryDateTime;
            OrderStatus = orderStatus;
        }
    }
}
