using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ACME.Documents
{
    public class Customer
    {
        public class PaymentMethod
        {
            public int PaymentID { get; set; }
            public string Code { get; set; }
            public string Number { get; set; }
        }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        public int CustomerID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public ICollection<PaymentMethod> PaymentMethods { get; set; }
        public ICollection<Address> Addresses { get; set; }

    }
}
