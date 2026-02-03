using HP2.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP2.Application.Contracts
{
    public interface IAsyncRepository<T> where T : BaseModel
    {
        //Task<IReadOnlyList<T>> GetAllAsync();
    }
}
