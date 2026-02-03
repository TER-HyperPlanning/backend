using AutoMapper;
using Microsoft.AspNetCore.Routing.Constraints;
using HP2.Domain.Models;
using HP2.Infrastructure.Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace HP2.Infrastructure.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<MatiereTest, MatiereTestModel>()
                .ReverseMap();

      
        }
    }
}
