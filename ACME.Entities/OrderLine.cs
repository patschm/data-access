using System;
using System.Collections.Generic;

#nullable disable

namespace ACME.Entities
{
    public partial class OrderLine
    {
        public int ProductId { get; set; }
        public long OrderId { get; set; }
        public int Quantity { get; set; }
        public double ListPrice { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
