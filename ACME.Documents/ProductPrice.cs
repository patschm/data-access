using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.Documents
{
    public class ProductPrice
    {
        public class ProductInfo
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public string Id { get; set; }
        public int ProductID { get; set; }
        public DateTime DateFrom { get; set; }
        public float Price { get; set; }
        public ProductInfo Product { get; set; }

    }
}
