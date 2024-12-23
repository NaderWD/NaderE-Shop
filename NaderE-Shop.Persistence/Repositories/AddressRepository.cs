using Microsoft.EntityFrameworkCore;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Domain.Models;

namespace NaderE_Shop.Persistence.Repositories
{
    public class AddressRepository(ShopDbContext Context) : GenericRepository<Address>(Context), IAddressRepository
    {
        private readonly ShopDbContext _Context = Context;

        public async Task<Address> GetAddressDetails(int id)
        {
            return await _Context.Set<Address>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Address>> GetAllAddresses()
        {
            return await _Context.Set<Address>().ToListAsync();
        }
    }
}
