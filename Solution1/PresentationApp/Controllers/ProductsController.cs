using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Application.Interfaces;

namespace PresentationApp.Controllers
{
    public class ProductsController : Controller
    {
        private IProductsServiceApp _prodService;
        public ProductsController(IProductsServiceApp prodService) {
            _prodService = prodService;
        }
        public IActionResult Index()
        {
            var list = _prodService.GetProducts();

            return View(list);
        }

        public IActionResult Details(Guid id)
        {
            return View(_prodService.GetProduct(id));

           
        }
    }
}
