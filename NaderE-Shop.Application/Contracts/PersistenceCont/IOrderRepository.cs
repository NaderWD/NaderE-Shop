using NaderE_Shop.Domain.Models;

namespace NaderE_Shop.Application.Contracts.PersistenceCont
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task<Order> GetOrderDetails(int id);
        Task<List<Order>> GetAllOrders();
    }
}
