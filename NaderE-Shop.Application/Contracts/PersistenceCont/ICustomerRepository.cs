using NaderE_Shop.Domain.Models;

namespace NaderE_Shop.Application.Contracts.PersistenceCont
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        Task<Customer> GetCustomerDetails(int id);
        Task<List<Customer>> GetAllCustomers();
    }
}
