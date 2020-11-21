using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Domain.Models;
using System.Linq;

namespace ShoppingCart.Domain.Interfaces
{
    public interface IProductRepository
    {

        Product GetProduct(Guid id); //ok
        IQueryable<Product> GetProducts();
       // IQueryable<Product> GetProducts(int category);

        Guid AddProduct(Product P);//ok

        void DeleteProduct(Guid id);//ok

        
    }
}
