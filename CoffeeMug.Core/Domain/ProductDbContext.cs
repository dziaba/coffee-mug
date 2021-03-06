﻿using Microsoft.EntityFrameworkCore;

namespace CoffeeMug.Core.Domain
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) {}
    }
}
