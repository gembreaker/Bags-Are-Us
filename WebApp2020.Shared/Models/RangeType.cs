using System;
using System.Collections.Generic;

namespace WebApp2020.Shared.Models
{
    public partial class RangeType
    {
        public RangeType()
        {
            ProductDetails = new HashSet<ProductDetails>();
        }

        public int RangeId { get; set; }
        public string RangeName { get; set; }

        public virtual ICollection<ProductDetails> ProductDetails { get; set; }
    }
}
