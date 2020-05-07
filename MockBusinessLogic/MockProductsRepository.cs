using ShoppingApp.Models.Products;
using ShoppingApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.MockBusinessLogic
{
    /// <summary>
    /// This Mock class is created for InMemory Changes
    /// </summary>
    public class MockProductsRepository : IProductsRepository
    {
        private List<Product> _productList;
        
        public Product Add(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Delete(int Id)
        {
            Product product = _productList.FirstOrDefault(p => p.Id == Id); //Getting product by Id to return
            if(product != null)
            {
                _productList.Remove(product); //Removing product from DB
            }
            return product; //Returning product which is deleted from DB
            
        }

        public Product GetProduct(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        public Product Update(Product productChanges)
        {
            Product product = _productList.FirstOrDefault(p => p.Id == productChanges.Id); //Getting product by Id to return
            if (product != null)
            {
                product.Id = productChanges.Id;
                product.Images = productChanges.Images;
                product.PCode = productChanges.PCode;
                product.PName = productChanges.PName;
                product.Price = productChanges.Price;
                product.SellerId = productChanges.SellerId;
                product.Size = productChanges.Size;
                product.Specifications = productChanges.Specifications;
                product.SubType = productChanges.SubType;
                product.Type = productChanges.Type;
                product.Weight = productChanges.Weight;
                product.BrandName = productChanges.BrandName;
                product.Category = productChanges.Category;
                product.Color = productChanges.Color;
                product.Description = productChanges.Description;
                product.Dimension = productChanges.Dimension;
            }
            return product;
        }
    }
}
