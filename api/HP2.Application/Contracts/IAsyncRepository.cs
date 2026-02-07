using System.Linq.Expressions;

namespace HP2.Application.Contracts
{
    public interface IAsyncRepository<T> where T : class
    {
        Task<T?> GetByIdAsync(string id);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate);
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(string id);
    }
}
