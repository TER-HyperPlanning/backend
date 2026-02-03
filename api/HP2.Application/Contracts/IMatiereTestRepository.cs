using HP2.Domain.Models;

namespace HP2.Application.Contracts
{
    public interface IMatiereTestRepository : IAsyncRepository<MatiereTestModel>
    {
        Task<IEnumerable<MatiereTestModel>> GetAllAsync();

        Task<MatiereTestModel> GetById(int id);
    }
}