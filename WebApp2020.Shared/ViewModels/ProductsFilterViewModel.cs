using System;
using System.Collections.Generic;
using System.Text;

using WebApp2020.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace WebApp2020.Shared.ViewModels
{
    public class ProductsFilterViewModel : BaseFilterViewModel
    {
        [Display(Name = "Filter By")]
        public ProductFilterColumns FilterField { get; set; }

        [Display(Name = "Search For")]
        public string FilterSearchString { get; set; }

        [Display(Name = "Sort By")]
        public ProductSortOptions SortBy { get; set; }
    }
}
