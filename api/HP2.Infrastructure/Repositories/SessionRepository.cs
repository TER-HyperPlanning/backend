using AutoMapper;
using HP2.Application.Contracts;
using HP2.Domain.Models;
using HP2.Infrastructure.Persistence;
using HP2.Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HP2.Infrastructure.Repositories
{
    public class SessionRepository : ISessionRepository
    {
        private readonly TerHyperplanningContext _context;
        private readonly IMapper _mapper;

        public SessionRepository(TerHyperplanningContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<SessionModel>> GetAllAsync()
        {
            var sessions = await _context.Sessions.ToListAsync();
            return _mapper.Map<IEnumerable<SessionModel>>(sessions);
        }

        public async Task<SessionModel?> GetByIdAsync(string id)
        {
            var session = await _context.Sessions.FindAsync(id);
            return session == null ? null : _mapper.Map<SessionModel>(session);
        }

        public async Task<SessionModel> AddAsync(SessionModel model)
        {
            var entity = _mapper.Map<Session>(model);
            entity.SessionId = Guid.NewGuid().ToString();
            await _context.Sessions.AddAsync(entity);
            await _context.SaveChangesAsync();
            return _mapper.Map<SessionModel>(entity);
        }

        public async Task<SessionModel?> UpdateAsync(SessionModel model)
        {
            var entity = await _context.Sessions.FindAsync(model.Id);
            if (entity == null) return null;

            _mapper.Map(model, entity);
            await _context.SaveChangesAsync();
            return _mapper.Map<SessionModel>(entity);
        }

        public async Task<bool> DeleteAsync(string id)
        {
            var entity = await _context.Sessions.FindAsync(id);
            if (entity == null) return false;

            _context.Sessions.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}