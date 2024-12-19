using NaderE_Shop.Domain.Models;

namespace NaderE_Shop.Application.Contracts.PersistenceCont
{
    public interface ICommentRepository : IGenericRepository<Comment>
    {
        Task<Comment> GetCommentDetails(int id);
        Task<List<Comment>> GetAllComments();
    }
}
