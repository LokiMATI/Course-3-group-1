namespace Store.Models.Entity
{
    public class BuyerEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        //public List<OrderEntity>? Orders { get; set; }
    }
}
