using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Models.Entity;

namespace Store.Models.Configurations
{
    public class BuyerConfiguration : IEntityTypeConfiguration<BuyerEntity>
    {
        public void Configure(EntityTypeBuilder<BuyerEntity> builder)
        {
            builder.HasKey(b => b.Id);
            //builder.HasMany(b => b.Orders).WithOne(o => o.BuyerId);
        }
    }
}
