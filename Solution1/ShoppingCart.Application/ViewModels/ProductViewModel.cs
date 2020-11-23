using ShoppingCart.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Application.ViewModels
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public GateoryViewModel Category { get; set; }

        public int Stock { get; set; }
        public string ImageURL { get; set; }
    }
}
