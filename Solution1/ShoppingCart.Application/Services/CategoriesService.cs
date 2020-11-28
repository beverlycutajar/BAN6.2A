using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Domain.Interfaces;
using ShoppingCart.Application.ViewModels;
using ShoppingCart.Application.Interfaces;
using System.Linq;


namespace ShoppingCart.Application.Services
{
    public class CategoriesService : ICategoriesService
    {
        private ICategoryRepository _categoryRepo;

        public CategoriesService(ICategoryRepository categoriesRepo)
        {
            _categoryRepo = categoriesRepo;
        }

        public IQueryable<GateoryViewModel> GetCategories()
        {
            var list = from x in _categoryRepo.GetCategories()
                       select new GateoryViewModel()
                       {
                           Id = x.Id,
                           Name = x.Name
                       };
            return list;
        }

      
    }
}
