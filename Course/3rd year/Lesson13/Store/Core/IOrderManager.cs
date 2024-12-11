using Store.Models.Entity;

namespace Store.Core
{
    public interface IOrderManager
    {
        void Add(OrderEntity orderEntity);
        void Remove(Guid Id);
        List<OrderEntity> GetAll();
        void Update(OrderEntity orderEntity);
    }
}
