using ShoppingBasket.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingBasket.Logic
{
    public interface IBasketLogic
    {
        void AddProductToBasket(Product product, Basket basket);
        decimal CalculateTotalCostOfBasket(Basket basket);
    }
}
