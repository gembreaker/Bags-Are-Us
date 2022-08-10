using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;

namespace WebApp2020.Shared.Enums
{
    public enum ProductFilterColumns
    {
        [Display(Name = "Show All")]
        NoFilter = 0,

        [Display(Name = "Range contains")]
        ByRange,

        [Display(Name = "Bag Type contains")]
        ByBagType,

        [Display(Name = "Colour contains")]
        ByColour,

        [Display(Name = "Range, Bag Type or Colour contains")]
        ByRangeTypeColour,

        [Display(Name = "Price <=")]
        ByPrice
    }
}
