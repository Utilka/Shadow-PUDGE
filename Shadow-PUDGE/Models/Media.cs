namespace Shadow_PUDGE.Models
{
    public class Media
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public DateTime CreatedAt { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
