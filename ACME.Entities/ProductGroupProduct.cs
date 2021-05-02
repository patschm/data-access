using System;
using System.Collections.Generic;

#nullable disable

namespace ACME.Entities
{
    public partial class ProductGroupProduct
    {
        public int ProductId { get; set; }
        public int ProductGroupId { get; set; }

        public virtual Product Product { get; set; }
        public virtual ProductGroup ProductGroup { get; set; }
    }
}
