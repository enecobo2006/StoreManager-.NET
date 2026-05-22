using Store.BLL.Entities;

namespace Store.BLL.Contracts
{
    public interface IProductManager
    {
        ProductBLL Add(ProductBLL product);
        ProductBLL GetById(int id);
        ProductBLL Update(int id, ProductBLL product);
        void Delete(int id);
        IEnumerable<ProductBLL> GetAll();
    }
}
