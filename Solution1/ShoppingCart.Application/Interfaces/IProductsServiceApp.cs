using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ShoppingCart.Domain.Models;
using ShoppingCart.Application.ViewModels;

namespace ShoppingCart.Application.Interfaces
{
    public interface IProductsServiceApp
    {
        //here we declare methods to be used in the application layer, beause it will be iinteracting with the presentation layer

        IQueryable<ProductViewModel> GetProducts();
       
        ProductViewModel GetProduct(Guid id);

        void AddProduct(ProductViewModel model);

    }
}
