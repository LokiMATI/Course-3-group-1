using Store.Models;
using Store.Models.Entity;

namespace Store.Core
{
    public class OrderManager : IOrderManager
    {
        private StoreDbContext _context;
        public OrderManager(StoreDbContext context)
        {
            _context = context;
        }
        public void Add(OrderEntity ordersEntity)
        {
            _context.Orders.Add(ordersEntity);
            _context.SaveChanges();
        }

        public List<OrderEntity> GetAll()
        {
            return _context.Orders.ToList();
        }

        public void Remove(Guid Id)
        {
            _context.Orders.Remove(GetAll().First(x => x.Id == Id));
            _context.SaveChanges();
        }

        public void Update(OrderEntity ordersEntity)
        {
            _context.Orders.Update(ordersEntity);
            _context.SaveChanges();
        }
    }
}
