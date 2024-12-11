namespace Store.Models.Entity
{
    public class ProductEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public float Price { get; set; } = 0;
        //public List<OrderEntity>? Orders { get; set; }
    }
}
