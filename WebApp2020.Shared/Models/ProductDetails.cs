using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace WebApp2020.Shared.Models
{
    public partial class ProductDetails
    {
        public ProductDetails()
        {
            ProductOrderDetails = new HashSet<ProductOrderDetails>();
        }

        [Required]
        [Display(Name = "Product Code")]
        public int ProductCode { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 1)]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [StringLength(255, ErrorMessage = "The {0} must be a max {1} characters long.")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Colour")]
        public int? ColourId { get; set; }
        [Display(Name = "Product Image")]
        public string ProductImage { get; set; }
        [Display(Name = "Upload Product Image")]
        [NotMapped]
        [DataType(DataType.Upload)]
        public IFormFile ProductImageFile { get; set; }
        [Required]
        [DataType(DataType.Currency, ErrorMessage = "The {0} must be an amount.")]
        public decimal Price { get; set; }
        [Display(Name = "Range")]
        [Required]
        public int? RangeId { get; set; }
        [Required]
        [Display(Name = "Bag Type")]
        public int? BagTypeId { get; set; }

        [Display(Name = "Bag Type")]
        public virtual BagType BagType { get; set; }
        public virtual Colour Colour { get; set; }
        public virtual RangeType Range { get; set; }
        public virtual ICollection<ProductOrderDetails> ProductOrderDetails { get; set; }
    }
}
