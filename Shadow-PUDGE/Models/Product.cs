using System.Collections.ObjectModel;

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
        public string Title { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; }
        public int PriceCompare { get; set; }
        public ProductStatus Shtatus { get; set; }
        public DateTime CreatedAt { get; set; }

        public List<Media> Medias { get; set; }
        public List<Order_item> Order_Items { get; set; }
        public List<Product_tag> Product_Tags { get; set; }
        public List<Collection_product> Collection_products { get; set; }
    }
}
