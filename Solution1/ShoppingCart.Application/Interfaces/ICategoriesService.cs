using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ShoppingCart.Application.ViewModels;
using ShoppingCart.Domain.Models;

namespace ShoppingCart.Application.Interfaces
{
    interface ICategoriesService
    {
        IQueryable<CategoryViewModel> GetCategories();
    }
}
