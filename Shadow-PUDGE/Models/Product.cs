using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Shadow_PUDGE.Models
{
    public enum ProductStatus
    {
        draft = 0,
        active = 1
    }

    public class Product
    {
        public int Id { get; set; }
        [StringLength(200, ErrorMessage = "The Title cannot exceed 200 characters. ")]
        public string Title { get; set; }
        public string? Description { get; set; }
        [Range(0, Int32.MaxValue, ErrorMessage = "Value should be greater than or equal to 0")]
        public int Price { get; set; }
        [Range(0, Int32.MaxValue, ErrorMessage = "Value should be greater than or equal to 0")]
        public int PriceCompare { get; set; }
        public ProductStatus Shtatus { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedAt { get; set; }

        [ValidateNever]
        public List<Media> Medias { get; set; }
        [ValidateNever]
        public List<Order_item> Order_Items { get; set; }
        [ValidateNever]
        public List<Product_tag> Product_Tags { get; set; }
        public List<Collection_product>? Collection_products { get; set; }
    }
}
