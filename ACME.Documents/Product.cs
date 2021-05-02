using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.Documents
{
    public class Product
    {
        public class Brand
        {
            public int BrandId { get; set; }
            public string Name { get; set; }
        }
        public class ProductGroup
        {
            public int ProductGroupId { get; set; }
            public ProductGroup Parent { get; set; }
            public string Name { get; set; }
        }
        [JsonProperty(PropertyName ="id")]
        public string Id { get; set; }
        public int ProductID { get; set; }
        public Product Family { get; set; }
        public string Name { get; set; }
        public Brand BrandInfo { get; set; }
        public ICollection<ProductGroup> ProductGroups { get; set; }
    }
}
