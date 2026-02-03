using Microsoft.AspNetCore.Mvc;
using HP2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP2.Application
{
    public interface IMatiereTestService
    {
        Task<IEnumerable<MatiereTestModel>> GetAll();

        Task<MatiereTestModel> GetById(int id);
    }
}
