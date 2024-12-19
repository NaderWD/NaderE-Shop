using NaderE_Shop.Domain.Models;

namespace NaderE_Shop.Application.Contracts.PersistenceCont
{
    public interface IAddressRepository : IGenericRepository<Address>
    {
        Task<Address> GetAddressDetails(int id);
        Task<List<Address>> GetAllAddresses();
    }
}
