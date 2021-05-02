using System;
using System.Collections.Generic;

#nullable disable

namespace ACME.Entities
{
    public partial class Product
    {
        public Product()
        {
            InverseFamily = new HashSet<Product>();
            OrderLines = new HashSet<OrderLine>();
            ProductGroupProducts = new HashSet<ProductGroupProduct>();
            ProductPrices = new HashSet<ProductPrice>();
        }

        public int Id { get; set; }
        public int? FamilyId { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Product Family { get; set; }
        public virtual ICollection<Product> InverseFamily { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
        public virtual ICollection<ProductGroupProduct> ProductGroupProducts { get; set; }
        public virtual ICollection<ProductPrice> ProductPrices { get; set; }
    }
}
