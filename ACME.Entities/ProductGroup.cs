using System;
using System.Collections.Generic;

#nullable disable

namespace ACME.Entities
{
    public partial class ProductGroup
    {
        public ProductGroup()
        {
            InverseParent = new HashSet<ProductGroup>();
            ProductGroupProducts = new HashSet<ProductGroupProduct>();
        }

        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }

        public virtual ProductGroup Parent { get; set; }
        public virtual ICollection<ProductGroup> InverseParent { get; set; }
        public virtual ICollection<ProductGroupProduct> ProductGroupProducts { get; set; }
    }
}
