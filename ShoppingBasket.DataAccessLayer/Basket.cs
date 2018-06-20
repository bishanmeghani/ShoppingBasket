using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket.DataAccessLayer
{
    public class Basket
    {
        public List<Product> ListOfProducts { get; set; }
        public Dictionary<string,int> QuantityOfEachItem { get; set; }
        public Dictionary<string,decimal> TotalPriceEachItem { get; set; }

        public Basket()
        {
            ListOfProducts = new List<Product>();
            QuantityOfEachItem = new Dictionary<string, int>();
            TotalPriceEachItem = new Dictionary<string, decimal>();
        }
    }
}
