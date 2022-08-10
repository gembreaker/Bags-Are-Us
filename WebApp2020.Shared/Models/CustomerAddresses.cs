using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace WebApp2020.Shared.Models
{
    public partial class CustomerAddresses
    {
        public int AddressId { get; set; }
        public string CustomerId { get; set; }

        public virtual Addresses Address { get; set; }

        [ForeignKey("CustomerId")]
        public IdentityUser User { get; set; }
    }
}
