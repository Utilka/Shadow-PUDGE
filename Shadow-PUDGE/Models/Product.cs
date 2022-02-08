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
        public ProductStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
