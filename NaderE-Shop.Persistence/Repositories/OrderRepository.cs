using Microsoft.EntityFrameworkCore;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Domain.Models;

namespace NaderE_Shop.Persistence.Repositories
{
    public class OrderRepository(ShopDbContext context) : GenericRepository<Order>(context), IOrderRepository
    {
        private readonly ShopDbContext _context = context;

        public async Task<Order> GetOrderDetails(int id)
        {
            return await _context.Set<Order>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Order>> GetAllOrders()
        {
            return await _context.Set<Order>().ToListAsync();
        }
    }
}
