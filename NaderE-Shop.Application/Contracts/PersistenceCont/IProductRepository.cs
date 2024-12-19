using NaderE_Shop.Domain.Models;

namespace NaderE_Shop.Application.Contracts.PersistenceCont
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<Product> GetProductDetails(int id);
        Task<List<Product>> GetAllProducts();
    }
}
