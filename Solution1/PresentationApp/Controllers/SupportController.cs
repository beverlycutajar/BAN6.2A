using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PresentationApp.Controllers
{
    public class SupportController : Controller
    {
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact (string email, string query)
        {
            if(string.IsNullOrEmpty(query) || string.IsNullOrEmpty(email))
            {
                ViewData["warning"] = "Kindly fill all the fields";
            }
            else
            ViewData["feedback"] = "Thanks for your query, we will be with you shortly";

            
            
            return View();
        }
    }
}
