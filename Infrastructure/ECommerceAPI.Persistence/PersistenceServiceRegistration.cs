using Microsoft.EntityFrameworkCore;
using ECommerceAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using ECommerceAPI.Application.Repositories.Customers;
using ECommerceAPI.Persistence.Repositories.Customers;
using ECommerceAPI.Application.Repositories.Orders;
using ECommerceAPI.Persistence.Repositories.Orders;
using ECommerceAPI.Application.Repositories.Products;
using ECommerceAPI.Persistence.Repositories.Products;
using System.Reflection;

namespace ECommerceAPI.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ECommerceAPIDbContext>(options =>
                                            options.UseNpgsql(configuration.GetConnectionString("PostgreSQL")));

            Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(x => x.Name.EndsWith("Repository") && !x.IsAbstract && !x.IsInterface)
            .Select(x => new { assignedType = x, serviceTypes = x.GetInterfaces().ToList() })
            .ToList()
            .ForEach(typesToRegister =>
            {
                typesToRegister.serviceTypes.ForEach(typeToRegister => services.AddScoped(typeToRegister, typesToRegister.assignedType));
            });
        }
    }
}
