﻿namespace Shadow_PUDGE.Models
{
    public class Product_tag
    {
        public int Id { get; set; }

        public int TagId { get; set; }
        public Tag Tag { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
