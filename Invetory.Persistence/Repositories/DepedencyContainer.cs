using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Invetory.Persistence.Interfaces;
using Invetory.Persistence.Repositories;
using Invetory.Entities;

namespace Invetory.Persistence.Repositories
{
    public static class DepedencyContainer
    {

        public static IServiceCollection AddContextSqlServer(
            this IServiceCollection services,
            IConfiguration configuration,
            string ConnectionString
            )
        {
            services.AddSqlServer<DataContext>(configuration.GetConnectionString(ConnectionString));

            return services;
        }

        public static IServiceCollection AddContextSqLite(
                  this IServiceCollection services,
                  IConfiguration configuration,
                  string ConnectionString
                  )
        {
            services.AddSqlite<DataContext>(configuration.GetConnectionString(ConnectionString));

            return services;
        }

        public static IServiceCollection AddRepositories(
               this IServiceCollection services
        ) {
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IInventoryMovementRepository, InventoryMovementRepository>();
            services.AddScoped<IInventoryStockRepository, InventoryStockRepository>();
            services.AddScoped<IMovementTypeRepository, MovementTypeRepository>();
            services.AddScoped<IProductReposotory, ProductRepository>();
            services.AddScoped<ISupplierRepository, SupplierRepository>();
           
             return services;
         }

    }
}