using Store.Models;
using Store.Models.Entity;

namespace Store.Core
{
    public class BuyerManager : IBuyerManager
    {
        private StoreDbContext _context;
        public BuyerManager(StoreDbContext context) 
        {
            _context = context;
        }
        public void Add(BuyerEntity buyerEntity)
        {
            _context.Buyers.Add(buyerEntity);
            _context.SaveChanges();
        }

        public List<BuyerEntity> GetAll()
        {
            return _context.Buyers.ToList();
        }

        public void Remove(Guid Id)
        {
            _context.Buyers.Remove(GetAll().First(x => x.Id == Id));
            _context.SaveChanges();
        }

        public void Update(BuyerEntity buyerEntity)
        {
            _context.Buyers.Update(buyerEntity);
            _context.SaveChanges();
        }
    }
}
