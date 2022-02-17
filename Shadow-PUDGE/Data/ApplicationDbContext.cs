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
                .HasMany<Media>(paroduct => paroduct.Medias)
                .WithOne(media => media.Product)
                .HasForeignKey(media => media.ProductId);
        }
    }
}