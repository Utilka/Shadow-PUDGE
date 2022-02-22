using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shadow_PUDGE.Models;

namespace Shadow_PUDGE.Data
{
    public class ApplicationDbContext : IdentityDbContext<CustomerDetails>
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<CustomerDetails> CustomerDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ProductCollection> ProductCollections { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<CustomerDetails>()
                .HasMany<Order>(customerDetails => customerDetails.Orders)
                .WithOne(order => order.CustomerDetails)
                .HasForeignKey(order => order.UserId);
            builder.Entity<Product>()
                .HasMany<Media>(product => product.Medias)
                .WithOne(media => media.Product)
                .HasForeignKey(media => media.ProductId);
            builder.Entity<Product>()
                .HasMany<Order_item>(product => product.Order_Items)
                .WithOne(order_item => order_item.Product)
                .HasForeignKey(order_item => order_item.ProductId);
            builder.Entity<Order>()
                .HasMany<Order_item>(order => order.Order_Items)
                .WithOne(order_item => order_item.Order)
                .HasForeignKey(order_item => order_item.OrderId);
            builder.Entity<Product>()
                .HasMany<Product_tag>(product => product.Product_Tags)
                .WithOne(pt => pt.Product)
                .HasForeignKey(pt => pt.ProductId);
            builder.Entity<Tag>()
                .HasMany<Product_tag>(t => t.Product_Tags)
                .WithOne(pt => pt.Tag)
                .HasForeignKey(pt => pt.TagId);
            builder.Entity<Product>()
                .HasMany<Collection_product>(product => product.Collection_products)
                .WithOne(pc => pc.Product)
                .HasForeignKey(pc => pc.ProductId);
            builder.Entity<ProductCollection>()
                .HasMany<Collection_product>(t => t.Collection_products)
                .WithOne(pc => pc.ProductCollection)
                .HasForeignKey(pc => pc.ProductCollectionId);
        }
    }
}