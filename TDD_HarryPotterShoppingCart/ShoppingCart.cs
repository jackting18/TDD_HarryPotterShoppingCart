using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD_HarryPotterShoppingCart.BE;

namespace TDD_HarryPotterShoppingCart
{
    public class ShoppingCart
    {
        public decimal Calculate(ShoppingCartEntity shoppingCart)
        {
            var totalPrice = shoppingCart.SalePageList.Sum(i => i.Qty * i.Price);

            return totalPrice;
        }
    }
}
