using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace WebApp2020.Shared.Models
{
    public partial class OrderDetails
    {
        public OrderDetails()
        {
            ProductOrderDetails = new HashSet<ProductOrderDetails>();
        }

        [Display(Name = "Order Code")]
        public int OrderId { get; set; }
        [Display(Name = "Customer ID")]
        public string CustomerId { get; set; }
        [Display(Name = "Payment Type ID")]
        public int? PaymentTypeId { get; set; }
        [Display(Name = "Date Ordered")]
        public DateTime DateOrdered { get; set; }
        [Display(Name = "Date Purchased")]
        public DateTime DatePurchased { get; set; }

        [Required]
        public int? Quantity { get; set; }
        public int ProductCode { get; set; }
        [Display(Name = "Product Name")]
        public virtual ProductDetails Product { get; set; }

        public virtual PaymentType PaymentType { get; set; }
        public virtual ICollection<ProductOrderDetails> ProductOrderDetails { get; set; }

        [ForeignKey("CustomerId")]
        public IdentityUser User { get; set; }
    }
}
