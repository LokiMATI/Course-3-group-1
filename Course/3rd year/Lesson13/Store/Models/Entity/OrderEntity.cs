namespace Store.Models.Entity
{
    public class OrderEntity
    {
        public Guid Id { get; set; }
        public BuyerEntity? BuyerId { get; set; }
        //public List<ProductEntity>? Products { get; set; }
    }
}
