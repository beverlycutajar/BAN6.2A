﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShoppingCart.Domain.Models
{
    public class CategoryViewModel
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
