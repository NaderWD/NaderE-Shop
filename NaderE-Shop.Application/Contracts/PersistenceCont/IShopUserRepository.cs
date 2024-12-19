using NaderE_Shop.Domain.Models;

namespace NaderE_Shop.Application.Contracts.PersistenceCont
{
    public interface IShopUserRepository : IGenericRepository<ShopUser>
    {
        Task<ShopUser> GetShopUserDetails(int id);
        Task<List<ShopUser>> GetAllShopUsers();
    }
}
