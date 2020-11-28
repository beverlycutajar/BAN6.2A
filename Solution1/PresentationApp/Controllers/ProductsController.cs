using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PresentationApp.Models;
using ShoppingCart.Application.Interfaces;

using ShoppingCart.Application.ViewModels;

namespace PresentationApp.Controllers
{
    public class ProductsController : Controller
    {
        private IProductsServiceApp _prodService;
        private ICategoriesService _catService;
        public ProductsController(IProductsServiceApp prodService, ICategoriesService catService) {
            _prodService = prodService;
            _catService = catService;
        }
        public IActionResult Index()
        {
            var list = _prodService.GetProducts();

            return View(list);
        }

        public IActionResult Details(Guid id)
        {
            var p = _prodService.GetProduct(id);
            return View(p);

           
        }

        //----------------------We need 2 mothods to add an item---------------------------------------------------

        [HttpGet] // this will be called before loading the Create page.
        public IActionResult Create()
        {
            CreateModel model = new CreateModel();

            var list = _catService.GetCategories();
            

            model.Catgeory = list.ToList();

            return View(model);
        }


        [HttpPost] // this is triggered when the user clicks the submit button
        public IActionResult Create (CreateModel data)
        {
            //validation
            try
            {
                _prodService.AddProduct(data.Product);
                ViewData["feedback"] = "Product Added";
                ModelState.Clear();
            }
            catch(Exception ex) {
                ViewData["Warning"] = "Product was not Added";
            }

            var list = _catService.GetCategories();
            data.Catgeory = list.ToList();


            return View(data);
        }
    }
}
