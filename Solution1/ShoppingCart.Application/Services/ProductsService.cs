using Microsoft.EntityFrameworkCore;
using ShoppingCart.Application.Interfaces;
using ShoppingCart.Application.ViewModels;
using ShoppingCart.Data.Repositories;
using ShoppingCart.Domain.Interfaces;
using ShoppingCart.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart.Application.Services
{
    public class ProductsService : IProductsServiceApp
    {
        private IProductRepository _productsRepo;
        public ProductsService (IProductRepository productsRepo)
        {
            _productsRepo = productsRepo;
        }

        public ProductViewModel GetProduct(Guid id)
        {
            var p = _productsRepo.GetProduct(id);
            return new ProductViewModel()
            {
                Id = p.Id,
                Description = p.Description,
                ImageURL = p.ImageURL,
                Price = p.Price,
                Category = new GateoryViewModel() { Id = p.Category.Id, Name = p.Category.Name }

            };
            
        }

        public IQueryable<ProductViewModel> GetProducts()
        {
            //this method will use LINQ to convert from IQueryable<Product> into IQueryable>ProductViewModel>
            var list = from p in _productsRepo.GetProducts().Include(x=> x.Category)    //Iqueryable method
                       select new ProductViewModel()
                       {
                           Id = p.Id,
                           Description = p.Description,
                           Name = p.Name,
                           Price = p.Price,
                           ImageURL = p.ImageURL,
                           Category = new GateoryViewModel() { Id = p.Category.Id, Name = p.Category.Name }

                       };
            return list;
        }

        void IProductsServiceApp.AddProduct(ProductViewModel model)
        {
            Product p = new Product()
            {
                Name = model.Name,
                Description = model.Description,
                ImageURL = model.ImageURL,
                Price = model.Price,
                Stock = model.Stock,
                CategoryId = model.Category.Id


            };
            _productsRepo.AddProduct(p);
        }
    }
}
