using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.Models.Products
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string   PName{ get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string BrandName { get; set; }
        public string Dimension { get; set; }
        public long Weight { get; set; }
        public string PCode { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public string Category { get; set; }
        [Required]
        public int SellerId { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Specifications { get; set; }
        public string Description { get; set; }
        public string Images { get; set; }
    }
}
