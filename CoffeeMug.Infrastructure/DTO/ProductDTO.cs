﻿using System;

namespace CoffeeMug.Infrastructure.DTO
{
    public class ProductDTO
    {
        public Guid Id { get; set; }
        public string Name { get;  set; }
        public decimal Price { get;  set; }
    }
}
