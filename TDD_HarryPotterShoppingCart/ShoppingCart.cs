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
            //// 3.如果你買了三本不同的書，則會有10%的折扣
            //// 4.如果是四本不同的書，則會有20 % 的折扣
            //// 5.如果你一次買了整套一到五集，恭喜你將享有25 % 的折扣
            //// 6.需要留意的是，如果你買了四本書，其中三本不同，第四本則是重複的，那麼那三本將享有10%的折扣，但重複的那一本，則仍須100元。

            //// 取得可以折扣的書本清單
            var disCountSalePageList = shoppingCart.SalePageList.GroupBy(i => i.Id).Select(s => s.FirstOrDefault()).ToList();

            //// 其餘沒有折扣的書本清單
            var otherSalePageList = shoppingCart.SalePageList.Except(disCountSalePageList).ToList();

            //// 取得可以折扣的書本的折扣數
            var discount = GetDiscount(disCountSalePageList.Count);

            var disCountTotalPrice = disCountSalePageList.Sum(i => i.Qty * i.Price) * discount;

            var otherTotalPrice = otherSalePageList.Sum(i => i.Qty * i.Price);

            //// 總價格為 折扣書本折扣後的價格 + 其餘未折扣書本原價價格
            var totalPrice = disCountTotalPrice + otherTotalPrice;

            return totalPrice;
        }

        private decimal GetDiscount(int count)
        {
            var discount = 1m;

            switch (count)
            {
                case 2:
                    discount = 0.95m;
                    break;
                case 3:
                    discount = 0.9m;
                    break;
                case 4:
                    discount = 0.8m;
                    break;
                case 5:
                    discount = 0.75m;
                    break;
                default:
                    break;
            }

            return discount;
        }
    }
}
