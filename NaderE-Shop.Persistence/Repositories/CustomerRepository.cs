using Microsoft.EntityFrameworkCore;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Domain.Models;

namespace NaderE_Shop.Persistence.Repositories
{
    public class CustomerRepository(ShopDbContext context) : GenericRepository<Customer>(context), ICustomerRepository
    {
        private readonly ShopDbContext _context = context;

        public async Task<Customer> GetCustomerDetails(int id)
        {
            return await _context.Set<Customer>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Customer>> GetAllCustomers()
        {
            return await _context.Set<Customer>().ToListAsync();
        }
    }
}
