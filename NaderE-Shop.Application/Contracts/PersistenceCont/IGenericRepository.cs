namespace NaderE_Shop.Application.Contracts.PersistenceCont
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Get(int id);
        Task<IReadOnlyList<T>> GetAll();
        Task<T> Add(T entity);
        Task<bool> Exist(int id);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
