using Microsoft.EntityFrameworkCore;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Domain.Models;

namespace NaderE_Shop.Persistence.Repositories
{
    public class CommentRepository(ShopDbContext context) : GenericRepository<Comment>(context), ICommentRepository
    {
        private readonly ShopDbContext _context = context;

        public async Task<Comment> GetCommentDetails(int id)
        {
            return await _context.Set<Comment>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Comment>> GetAllComments()
        {
            return await _context.Set<Comment>().ToListAsync();
        }
    }
}
