using Microsoft.EntityFrameworkCore;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Domain.Models;

namespace NaderE_Shop.Persistence.Repositories
{
    public class ShoppingCartRepository(ShopDbContext context) : GenericRepository<ShoppingCart>(context), IShoppingCartRepository
    {
        private readonly ShopDbContext _context = context;

        public async Task<ShoppingCart> GetShoppingCartDetails(int id)
        {
            return await _context.Set<ShoppingCart>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<ShoppingCart>> GetAllShoppingCarts()
        {
            return await _context.Set<ShoppingCart>().ToListAsync();
        }

        public async Task ChangeStatusToPaid(ShoppingCart cart, bool changeStatus)
        {
            cart.IsPaid = changeStatus;
            _context.Entry(cart).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
