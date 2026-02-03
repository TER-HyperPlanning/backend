using HP2.Application.Contracts;
using HP2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP2.Application
{
    public class MatiereTestService : IMatiereTestService
    {
        private readonly IMatiereTestRepository MatiereTestRepository;

        public MatiereTestService(IMatiereTestRepository matiereTestRepository)
        {
            this.MatiereTestRepository = matiereTestRepository;
        }

        public async Task<IEnumerable<MatiereTestModel>> GetAll()
        {

            return await this.MatiereTestRepository.GetAllAsync();
        }

        public async Task<MatiereTestModel> GetById(int id)
        {
            return await this.MatiereTestRepository.GetById(id);
        }
        
    }
}
