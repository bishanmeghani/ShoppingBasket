using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket.DataAccessLayer
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool Discounted { get; set; }
        public int DiscountQuantity { get; set; }
        public decimal DiscountPrice { get; set; }

    }
}
