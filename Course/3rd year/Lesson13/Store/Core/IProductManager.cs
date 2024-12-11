using Store.Models.Entity;

namespace Store.Core
{
    public interface IProductManager
    {
        void Add(ProductEntity buyerEntity);  
        void Remove(Guid Id);
        List<ProductEntity> GetAll();
        void Update(ProductEntity buyerEntity);
    }
}
