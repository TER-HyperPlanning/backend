using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Scaffolding;


namespace HP2.Infrastructure.Persistence
{
    public class CustomScaffoldingDesignTimeServices : IDesignTimeServices
    {
        public void ConfigureDesignTimeServices(IServiceCollection services)
        {
            services.AddSingleton<CustomPluralizer>();
        }
    }

    public class CustomPluralizer
    {
        public string Pluralize(string name) => name;

        public string Singularize(string name) => name + "Entity"; // Ajoute "Entity" à la fin du nom
    }
}
