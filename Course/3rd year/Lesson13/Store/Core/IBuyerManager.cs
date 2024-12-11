using Store.Models.Entity;

namespace Store.Core
{
    public interface IBuyerManager
    {
        void Add(BuyerEntity productEntity);
        void Remove(Guid Id);
        List<BuyerEntity> GetAll();
        void Update(BuyerEntity productEntity);
    }
}
