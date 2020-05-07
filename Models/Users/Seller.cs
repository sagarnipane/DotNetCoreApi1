using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.Models.Users
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public long Mobile { get; set; }
        public string ShopName { get; set; }
        public string ShopAddress { get; set; }
        public bool IsVerifiedSeller { get; set; }
    }
}
