using ShoppingCart.Data.Context;
using ShoppingCart.Domain.Interfaces;
using ShoppingCart.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart.Data.Repositories
{
    public class ProductsRepository : IProductRepository
    {
        ShoppingCartDbContext context;
        public ProductsRepository(ShoppingCartDbContext _context)
        {
            _context = context;
        }
        public Guid AddProduct(Product P)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(Product P)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(Guid id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Product> GetProducts()
        {
            
            throw new NotImplementedException();
        }
    }
}
