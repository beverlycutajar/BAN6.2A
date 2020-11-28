using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ShoppingCart.Application.ViewModels;


namespace ShoppingCart.Application.Interfaces
{
    public interface ICategoriesService
    {
        IQueryable<GateoryViewModel> GetCategories();
    }
}
