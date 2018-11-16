using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fii.Data
{
    public class ShoppingCartContext : DbContext
    {
        public ShoppingCartContext(DbContextOptions<ShoppingCartContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
    }
}
