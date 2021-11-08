namespace BrainWare.Infrastructure.Mappings
{
    using Domain.Models;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class OrderProductMapping : IEntityTypeConfiguration<OrderProduct>
    {
        public void Configure(EntityTypeBuilder<OrderProduct> builder)
        {
            builder.ToTable("OrderProduct");
            builder.Property(x => x.OrderId).HasColumnName("order_id");
            builder.Property(x => x.ProductId).HasColumnName("product_id");
            builder.HasKey(x => new { x.OrderId, x.ProductId });
            builder.HasOne(x => x.Order);
            builder.HasOne(x => x.Product);
        }
    }
}