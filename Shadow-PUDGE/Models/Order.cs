namespace Shadow_PUDGE.Models
{
    public enum OrderStatus
    {
        draft = 0,
        active = 1
    }
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public OrderStatus Status { get; set; }

        public string UserId { get; set; }
        public CustomerDetails CustomerDetails { get; set; }
    }
}
