using Microsoft.EntityFrameworkCore;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Domain.Models;

namespace NaderE_Shop.Persistence.Repositories
{
    public class ShopUserRepository(ShopDbContext context) : GenericRepository<ShopUser>(context), IShopUserRepository
    {
        private readonly ShopDbContext _context = context;

        public async Task<ShopUser> GetShopUserDetails(int id)
        {
            return await _context.Set<ShopUser>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<ShopUser>> GetAllShopUsers()
        {
            return await _context.Set<ShopUser>().ToListAsync();
        }
    }
}
