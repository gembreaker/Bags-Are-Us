using System;
using System.Collections.Generic;

namespace WebApp2020.Shared.Models
{
    public partial class BagType
    {
        public BagType()
        {
            ProductDetails = new HashSet<ProductDetails>();
        }

        public int BagTypeId { get; set; }
        public string BagType1 { get; set; }

        public virtual ICollection<ProductDetails> ProductDetails { get; set; }
    }
}