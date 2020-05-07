using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Web.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoppingApp.Models;
using ShoppingApp.Models.Products;

namespace ShoppingApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ShoppingAppDbContext _context;
        public ProductsController(ShoppingAppDbContext context)
        {
            _context = context;
        }

        // GET: Products/GetAllProduct
        [Route("GetAllProduct")]
        [HttpGet]
        public async Task<IList<Product>> Get()
        {
            return await _context.Product.ToListAsync();
        }
        // GET: Products/GetProductDetails/5
        [Route("GetProductDetails")]
        [HttpGet]
        public async Task<Product> Details(int? id)
        {
            if (id == null)
            {
                return null;
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return (null);
            }

            return product;
        }

        [Route("SaveProduct")]
        [HttpPost]
        public async Task<Product> Add(Product product)
        {
            if(product != null)
            {
                _context.Product.Add(product);
                await _context.SaveChangesAsync();
            }
            return product;
        }

    }
}