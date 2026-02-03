using AutoMapper;
using HP2.Application.Contracts;
using HP2.Domain.Models;
using HP2.Infrastructure.Persistence.Entities;
using HP2.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortie.Infrastructure.Repositories
{
    public class MatiereTestRepository : RepositoryBase<MatiereTestModel>, IMatiereTestRepository
    {
        private readonly IMapper _mapper;

        public MatiereTestRepository(M1i2526DbContext dbContext, IMapper mapper) : base(dbContext)
        {
            _mapper = mapper;
        }

        public async Task<IEnumerable<MatiereTestModel>> GetAllAsync()
        {
            var MatiereTestList = await _dbContext.MatiereTests.ToListAsync();

            var MatiereTestEntityList = _mapper.Map<List<MatiereTestModel>>(MatiereTestList);

            return MatiereTestEntityList;
        }

        public async Task<MatiereTestModel> GetById(int id)
        {
            var MatiereTest = await _dbContext.MatiereTests.FirstOrDefaultAsync(x => x.Id == id);
            return _mapper.Map<MatiereTestModel>(MatiereTest);
        }
       
    }








}

    

