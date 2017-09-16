using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD_HarryPotterShoppingCart.BE;

namespace TDD_HarryPotterShoppingCart
{
    /// <summary>
    /// ShoppingCart
    /// </summary>
    public class ShoppingCart
    {
        /// <summary>
        /// Calculate
        /// </summary>
        /// <param name="shoppingCart">The shopping cart.</param>
        /// <returns>總金額</returns>
        public decimal Calculate(ShoppingCartEntity shoppingCart)
        {
            //// 1.一到五集的哈利波特，每一本都是賣100元
            //// 2.如果你從這個系列買了兩本不同的書，則會有5%的折扣
            var count = shoppingCart.SalePageList.Select(i => i.Id).Distinct().Count();

            var totalPrice = shoppingCart.SalePageList.Sum(i => i.Qty * i.Price);
            if (count >= 2)
            {
                totalPrice = totalPrice * 0.95m;
            }

            return totalPrice;
        }
    }
}
