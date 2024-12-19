using NaderE_Shop.Domain.Models;

namespace NaderE_Shop.Application.Contracts.PersistenceCont
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task<Category> GetCategoryDetails(int id);
        Task<List<Category>> GetAllCategories();
    }
}
