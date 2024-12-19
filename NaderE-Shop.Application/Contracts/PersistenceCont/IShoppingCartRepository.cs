using NaderE_Shop.Domain.Models;

namespace NaderE_Shop.Application.Contracts.PersistenceCont
{
    public interface IShoppingCartRepository : IGenericRepository<ShoppingCart>
    {
        Task<ShoppingCart>? GetShoppingCartDetails(int id);
        Task<List<ShoppingCart>> GetAllShoppingCarts();
        Task ChangeStatusToPaid(ShoppingCart cart, bool changeStatus);
    }
}
