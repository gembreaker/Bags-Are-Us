using System;
using System.Collections.Generic;

namespace WebApp2020.Shared.Models
{
    public partial class ProductOrderDetails
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal? TotalPrice { get; set; }

        public virtual OrderDetails Order { get; set; }
        public virtual ProductDetails Product { get; set; }
    }
}
