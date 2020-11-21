using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShoppingCart.Application.Interfaces;
using ShoppingCart.Application.Services;
using ShoppingCart.Data.Context;
using ShoppingCart.Data.Repositories;
using ShoppingCart.Domain.Interfaces;

namespace ShoppingCart.IOC
{
    public class DependencyContainer
    {

        //this is called when the application needs to do associations
        // why does it need to do associations? So whenever there's another call that demands an instance of a class which 
        //has been declared in the following method, the reister services method creates an instance of that demand 'class'. 
        //We are also informing the RegisterServices about the associations that exist between the interfaces - implementation

        //AddScoped : 
        //Singleton : IoC Container will create and share a single instance of a service thorughtout the application of a lifetime
        // Transient L The IoC container will create a new instance of the specified service type every time you ask for it. 
        // Scoped : IoC container will create an instance of the specified service type once per request and will be shared in a single request
        public static void RegisterServices(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ShoppingCartDbContext>(options =>
            options.UseSqlServer(connectionString));

            services.AddScoped<IProductRepository, ProductsRepository>();  //grab the things in the lists so that they can use each other.
            services.AddScoped<IProductsServiceApp, ProductsService>(); //attaching the Interface to the class
        }
    }
}
