using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.Documents
{
    public class Order
    {
        public class OrderLine
        {
            public int ProductId { get; set; }
            public int Quantity { get; set; }
            public double ListPrice { get; set; }
        }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        public int OrderID { get; set; }
        public int CustomerId { get; set; }
        public int PaymentId { get; set; }
        public string OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime PayedDate { get; set; }
        public double? TotalPrice { get; set; }
        public Address DeliveryAddress { get; set; }
        public ICollection<OrderLine> OrderLines { get; set; }
        
    }
}
