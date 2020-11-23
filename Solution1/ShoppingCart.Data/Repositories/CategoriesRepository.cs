using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ShoppingCart.Domain.Interfaces;
using ShoppingCart.Domain.Models;
using ShoppingCart.Data.Context;

namespace ShoppingCart.Data.Repositories
{
    public class CategoriesRepository : ICategoryRepository
    {
        private ShoppingCartDbContext _context;
        public CategoriesRepository(ShoppingCartDbContext context)
        {
            _context = context;
        }

        public IQueryable<CategoryViewModel> GetCategories()
        {
            throw new NotImplementedException();
        }
    }
}
