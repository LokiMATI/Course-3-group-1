using Store.Models;
using Store.Models.Entity;

namespace Store.Core
{
    public class ProductManager : IProductManager
    {
        private readonly StoreDbContext _context;
        public ProductManager(StoreDbContext context)
        {
            _context = context;
        }
        public void Add(ProductEntity productEntity)
        {
            _context.Product.Add(productEntity);
            _context.SaveChanges();
        }

        public List<ProductEntity> GetAll()
        {
            return _context.Product.ToList();
        }

        public void Remove(Guid Id)
        {
            _context.Product.Remove(GetAll().First(x => x.Id == Id));
            _context.SaveChanges();
        }

        public void Update(ProductEntity productEntity)
        {
            _context.Product.Update(productEntity);
            _context.SaveChanges();
        }
    }
}
