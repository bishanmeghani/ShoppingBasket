using System;
using ShoppingBasket.DataAccessLayer;
using System.Collections.Generic;

namespace ShoppingBasket.Logic
{
    public class BasketLogic : IBasketLogic
    {
        public StockDb stockDb;

        public BasketLogic()
        {
            stockDb = new StockDb();
        }

        public void AddProductToBasket(Product product, Basket basket)
        {
            basket.ListOfProducts.Add(product);
        }

        public decimal CalculateTotalCostOfBasket(Basket basket)
        {
            decimal total = 0.0m;
            
            basket.TotalPriceEachItem.Add("A", 0.00m);
            basket.TotalPriceEachItem.Add("B", 0.00m);
            basket.TotalPriceEachItem.Add("C", 0.00m);
            basket.TotalPriceEachItem.Add("D", 0.00m);

            Dictionary<string, int> itemRecord = new Dictionary<string, int>();
            return total;
        }
    }
}
