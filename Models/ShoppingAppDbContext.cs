using Microsoft.EntityFrameworkCore;
using ShoppingApp.Models.Products;
using ShoppingApp.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.Models
{
    public class ShoppingAppDbContext :DbContext
    {
        public ShoppingAppDbContext(DbContextOptions<ShoppingAppDbContext> options): base(options)
        {
            
        }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}
