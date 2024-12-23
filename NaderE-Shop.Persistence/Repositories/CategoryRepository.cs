using Microsoft.EntityFrameworkCore;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Domain.Models;

namespace NaderE_Shop.Persistence.Repositories
{
    public class CategoryRepository(ShopDbContext context) : GenericRepository<Category>(context), ICategoryRepository
    {
        private readonly ShopDbContext _context = context;

        public async Task<Category> GetCategoryDetails(int id)
        {
            return await _context.Set<Category>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Category>> GetAllCategories()
        {
            return await _context.Set<Category>().ToListAsync();
        }
    }
}
