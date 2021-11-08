namespace BrainWare.Data
{
    using Domain.Models;

    using Infrastructure.Mappings;

    using Microsoft.EntityFrameworkCore;

    public class OrderContext : DbContext
    {
        public OrderContext()
        {
        }

        public OrderContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OrderMapping())
                        .ApplyConfiguration(new ProductMapping())
                        .ApplyConfiguration(new OrderProductMapping());
        }
    }
}