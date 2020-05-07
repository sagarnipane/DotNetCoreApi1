using ShoppingApp.Models;
using ShoppingApp.Models.Products;
using ShoppingApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.SQLRepository
{
    public class SQLProductsRepository : IProductsRepository
    {
        private readonly ShoppingAppDbContext Context;
        public SQLProductsRepository(ShoppingAppDbContext Context)
        {
            this.Context = Context;
        }

        public Product Add(Product product)
        {
            Context.Product.Add(product);
            Context.SaveChanges();
            return product;
        }

        public Product Delete(int Id)
        {
            Product product = Context.Product.Find(Id);
            if(product != null)
            {
                Context.Product.Remove(product);
                Context.SaveChanges();
            }
            return product;
        }

        public Product GetProduct(int Id)
        {
            return Context.Product.Find(Id);
            
        }

        public IEnumerable<Product> GetProducts()
        {
            return Context.Product;
        }

        public Product Update(Product productChanges)
        {
            var product = Context.Product.Attach(productChanges);
            product.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Context.SaveChanges();
            return productChanges;
        }
    }
}
