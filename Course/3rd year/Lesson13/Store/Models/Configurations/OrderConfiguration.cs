using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Models.Entity;

namespace Store.Models.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<OrderEntity>
    {
        public void Configure(EntityTypeBuilder<OrderEntity> builder)
        {
            builder.HasKey(o => o.Id);
            //builder.HasOne(o => o.BuyerId).WithMany(b => b.Orders);
            //builder.HasMany(o => o.Products).WithMany(p => p.Orders);
        }
    }
}
