using Microsoft.EntityFrameworkCore;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Domain.Models;

namespace NaderE_Shop.Persistence.Repositories
{
    public class ProductRepository(ShopDbContext context) : GenericRepository<Product>(context), IProductRepository
    {
        private readonly ShopDbContext _context = context;

        public async Task<Product> GetProductDetails(int id)
        {
            return await _context.Set<Product>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _context.Set<Product>().ToListAsync();
        }
    }
}
