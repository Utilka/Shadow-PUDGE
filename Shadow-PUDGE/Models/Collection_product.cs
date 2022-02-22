namespace Shadow_PUDGE.Models
{
    public class Collection_product
    {
        public int Id { get; set; }

        public int ProductCollectionId { get; set; }
        public ProductCollection ProductCollection { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
