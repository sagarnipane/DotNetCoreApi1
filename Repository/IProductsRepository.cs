using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingApp.Models.Products;

namespace ShoppingApp.Repository
{
    interface IProductsRepository
    {
        Product GetProduct(int Id);
        IEnumerable<Product> GetProducts();
        Product Add(Product product);
        Product Update(Product productChanges);
        Product Delete(int Id);
    }
}
