using System;
using System.Collections.Generic;

namespace WebApp2020.Shared.Models
{
    public partial class Addresses
    {
        public Addresses()
        {
            CustomerAddresses = new HashSet<CustomerAddresses>();
        }

        public int AddressId { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }

        public virtual ICollection<CustomerAddresses> CustomerAddresses { get; set; }
    }
}
