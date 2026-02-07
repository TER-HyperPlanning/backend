using HP2.Application.Contracts;
using HP2.Domain.Common;
using HP2.Infrastructure.Persistence.Entities;
using AutoMapper;

namespace HP2.Infrastructure.Repositories
{
    public class RepositoryBase<T> : IAsyncRepository<T> where T : BaseModel
    {
        protected readonly TerHyperplanningContext _dbContext;
        protected readonly IMapper _mapper;

        public RepositoryBase(TerHyperplanningContext dbContext,  IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        // public async Task<IReadOnlyList<T>> GetAllAsync()
        // {
        //     return await _dbContext.Set<T>().ToListAsync();
        // }

        // Note: Specific repositories should override these methods with proper Entity-to-Model mapping
        public virtual Task<T?> GetByIdAsync(string id)
        {
            throw new NotImplementedException("Override in specific repository");
        }

        public virtual Task<IReadOnlyList<T>> GetAllAsync()
        {
            throw new NotImplementedException("Override in specific repository");
        }

        public virtual Task<IReadOnlyList<T>> GetAsync(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException("Override in specific repository");
        }

        public virtual Task<T> AddAsync(T entity)
        {
            throw new NotImplementedException("Override in specific repository");
        }

        public virtual Task UpdateAsync(T entity)
        {
            throw new NotImplementedException("Override in specific repository");
        }

        public virtual Task DeleteAsync(string id)
        {
            throw new NotImplementedException("Override in specific repository");
        }
    }
}