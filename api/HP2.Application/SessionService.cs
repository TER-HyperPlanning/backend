using HP2.Application.Contracts;
using HP2.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HP2.Application
{
    public class SessionService : ISessionService
    {
        private readonly ISessionRepository _repository;

        public SessionService(ISessionRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<SessionModel>> GetAllAsync() => _repository.GetAllAsync();
        public Task<SessionModel?> GetByIdAsync(string id) => _repository.GetByIdAsync(id);
        public Task<SessionModel> AddAsync(SessionModel model) => _repository.AddAsync(model);
        public Task<SessionModel?> UpdateAsync(SessionModel model) => _repository.UpdateAsync(model);
        public Task<bool> DeleteAsync(string id) => _repository.DeleteAsync(id);
    }
}