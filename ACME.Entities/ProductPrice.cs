using System;
using System.Collections.Generic;

#nullable disable

namespace ACME.Entities
{
    public partial class ProductPrice
    {
        public int ProductId { get; set; }
        public DateTime DateFrom { get; set; }
        public double Price { get; set; }

        public virtual Product Product { get; set; }
    }
}
