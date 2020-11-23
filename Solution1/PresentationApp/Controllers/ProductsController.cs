using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Application.Interfaces;
using ShoppingCart.Application.ViewModels;

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

        //----------------------We need 2 mothods to add an item---------------------------------------------------

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create (ProductViewModel data)
        {
            try
            {
                _prodService.AddProduct(data);
                ViewData["feedback"] = "Product Added";
                ModelState.Clear();
            }
            catch(Exception ex) {
                ViewData["Warning"] = "Product was not Added";
            }
            return View();
        }
    }
}
