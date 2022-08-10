using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;

namespace WebApp2020.Shared.Enums
{
    public enum ProductSortOptions
    {
        [Display(Name = "Sort By...")]
        DefaultOrder,

        [Display(Name = "Newest first")]
        ByNewest,

        [Display(Name = "Price - Low to High")]
        ByPriceLowtoHigh,

        [Display(Name = "Price - High to Low")]
        ByPriceHightoLow
    }
}
