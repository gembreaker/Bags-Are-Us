using System;
using System.Collections.Generic;
using System.Text;

using WebApp2020.Shared.Models;
using WebApp2020.Shared.ViewModels;
using WebApp2020.Shared.Enums;
using System.Linq;

namespace WebApp2020.Shared.Queryables
{
    public class ProductFilterQueries
    {
        public static IQueryable<ProductDetails> ApplyQueryFilter(IQueryable<ProductDetails> productDetails, ProductsFilterViewModel productsFilter)
        {
            // Check if a FilterField has been specified (i.e. not set to No Filter - Show All)
            // Check if a FilterSearchString, i.e. something to search for, has been specified

            if (productsFilter.FilterField != ProductFilterColumns.NoFilter && !string.IsNullOrEmpty(productsFilter.FilterSearchString))
            {
                switch(productsFilter.FilterField)
                {
                    case ProductFilterColumns.ByRange:
                        return productDetails.Where(p => p.Range.RangeName.Contains(productsFilter.FilterSearchString));

                    case ProductFilterColumns.ByBagType:
                        return productDetails.Where(p => p.BagType.BagType1.Contains(productsFilter.FilterSearchString));

                    case ProductFilterColumns.ByColour:
                        return productDetails.Where(p => p.Colour.ColourName.Contains(productsFilter.FilterSearchString));

                    case ProductFilterColumns.ByRangeTypeColour:
                        return productDetails.Where(p => p.Range.RangeName.Contains(productsFilter.FilterSearchString) || p.BagType.BagType1.Contains(productsFilter.FilterSearchString) || p.Colour.ColourName.Contains(productsFilter.FilterSearchString));

                    case ProductFilterColumns.ByPrice:
                        decimal price = 0;
                        decimal.TryParse(productsFilter.FilterSearchString, out price);

                        if(price > 0)
                        {
                            return productDetails.Where(p => p.Price <= price);
                        }

                        return productDetails;
                }
            }

            return productDetails;
        }

        public static IQueryable<ProductDetails> ApplyQuerySort(IQueryable<ProductDetails> productDetails, ProductsFilterViewModel productsFilter)
        {
            switch(productsFilter.SortBy)
            {
                case ProductSortOptions.ByNewest:
                    return productDetails.OrderByDescending(p => p.ProductCode);

                case ProductSortOptions.ByPriceLowtoHigh:
                    return productDetails.OrderBy(p => p.Price);

                case ProductSortOptions.ByPriceHightoLow:
                    return productDetails.OrderByDescending(p => p.Price);
            }

            return productDetails;
        }

        public static IQueryable<ProductDetails> ApplyQueryFetchRange(IQueryable<ProductDetails> productDetails, ProductsFilterViewModel productsFilter)
        {
            return productDetails.Skip(productsFilter.SkipCount).Take(productsFilter.PageSize);
        }
    }
}