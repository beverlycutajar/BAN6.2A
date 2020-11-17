using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using ShoppingCart.Data.Repositories;

namespace ShoppingCart.IOC
{
    class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<ProductsRepository, ProductsRepository>();  //grab the things in the lists so that they can use each other.

        }
    }
}
