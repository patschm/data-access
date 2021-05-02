using System;
using System.Collections.Generic;

#nullable disable

namespace ACME.Entities
{
    public partial class Order
    {
        public Order()
        {
            OrderLines = new HashSet<OrderLine>();
        }

        public long Id { get; set; }
        public int CustomerId { get; set; }
        public int PaymentMethodId { get; set; }
        public int OrderStatusId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime PayedDate { get; set; }
        public double? TotalPrice { get; set; }
        public int DeliveryAddressId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Address DeliveryAddress { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}
