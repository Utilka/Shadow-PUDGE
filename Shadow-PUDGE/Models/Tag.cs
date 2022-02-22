namespace Shadow_PUDGE.Models
{
    public class Tag
    { 
        public int Id { get; set; }
        public string Handle { get; set; }

        public List<Product_tag> Product_Tags { get; set; }
    }
}
