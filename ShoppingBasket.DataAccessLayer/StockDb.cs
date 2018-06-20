using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket.DataAccessLayer
{
    public class StockDb
    {
        public Product ProductA { get; set; }
        public Product ProductB { get; set; }
        public Product ProductC { get; set; }
        public Product ProductD { get; set; }
        public Dictionary<string,Product> StockList { get; set; }

        Product[] Products = new Product[4];

        public StockDb()
        {
            Products[0] = new Product() { Id = 1, Name = "A", Price = 5.00M, Discounted = true, DiscountQuantity = 3, DiscountPrice = 13.00M };
            Products[1] = new Product() { Id = 2, Name = "B", Price = 3.00M, Discounted = true, DiscountQuantity = 3, DiscountPrice = 13.00M };
            Products[2] = new Product() { Id = 3, Name = "C", Price = 2.00M, Discounted = false };
            Products[3] = new Product() { Id = 4, Name = "D", Price = 1.00M, Discounted = false };

            StockList = new Dictionary<string, Product>();

            for (int i = 0; i < Products.Length; i++)
            {
                StockList.Add(Products[i].Name, Products[i]);
            }
        }
    }
}
