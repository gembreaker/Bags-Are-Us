using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace WebApp2020.Shared.Models
{
    public partial class PaymentType
    {
        public PaymentType()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int PaymentTypeId { get; set; }
        public string CustomerId { get; set; }
        public string PaymentMethod { get; set; }
        public string NameOnCard { get; set; }
        public int CardNumber { get; set; }
        public string ExpirationDate { get; set; }

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }

        [ForeignKey("CustomerId")]
        public IdentityUser User { get; set; }
    }
}
