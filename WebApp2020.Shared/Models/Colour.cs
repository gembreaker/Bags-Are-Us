using System;
using System.Collections.Generic;

namespace WebApp2020.Shared.Models
{
    public partial class Colour
    {
        public Colour()
        {
            ProductDetails = new HashSet<ProductDetails>();
        }

        public int ColourId { get; set; }
        public string ColourName { get; set; }

        public virtual ICollection<ProductDetails> ProductDetails { get; set; }
    }
}
