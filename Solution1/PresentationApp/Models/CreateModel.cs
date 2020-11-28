using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingCart.Application.ViewModels;
using ShoppingCart.Domain.Models;

namespace PresentationApp.Models
{
    public class CreateModel
    {

        public ProductViewModel Product { get; set; }
        public List<GateoryViewModel> Catgeory { get; set; }
    }
}
