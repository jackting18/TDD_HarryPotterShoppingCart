using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD_HarryPotterShoppingCart.BE;
using Xunit;

namespace TDD_HarryPotterShoppingCart.Test
{
    public class ShoppingCartTest
    {
        [Fact]
        public void Buy_1_HarryPort1_TotalPrice_Should_Be_100()
        {
            //// Arrange
            var expected = 100;

            var target = new ShoppingCart();

            var shoppingCart = new ShoppingCartEntity
            {
                SalePageList = new List<SalePageEntity>()
                {
                    new SalePageEntity(){Id = 1, Price = 100, Qty = 1}
                }
            };

            decimal actual = 0m;

            //// Act
            actual = target.Calculate(shoppingCart);

            //// Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Buy_1_HarryPort1_And_1_HarryPort2_TotalPrice_Should_Be_200()
        {
            //// Arrange
            var expected = 200;

            var target = new ShoppingCart();

            var shoppingCart = new ShoppingCartEntity
            {
                SalePageList = new List<SalePageEntity>()
                {
                    new SalePageEntity(){Id = 1, Price = 100, Qty = 1},
                    new SalePageEntity(){Id = 2, Price = 100, Qty = 1}
                }
            };

            decimal actual = 0m;

            //// Act
            actual = target.Calculate(shoppingCart);

            //// Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Buy_2_HarryPort1_And_1_HarryPort2_TotalPrice_Should_Be_200()
        {
            //// Arrange
            var expected = 300;

            var target = new ShoppingCart();

            var shoppingCart = new ShoppingCartEntity
            {
                SalePageList = new List<SalePageEntity>()
                {
                    new SalePageEntity(){Id = 1, Price = 100, Qty = 2},
                    new SalePageEntity(){Id = 2, Price = 100, Qty = 1}
                }
            };

            decimal actual = 0m;

            //// Act
            actual = target.Calculate(shoppingCart);

            //// Assert
            Assert.Equal(expected, actual);
        }
    }
}
