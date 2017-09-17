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
        public void Buy_HarryPort_Different2_TotalPrice_Should_Be_190()
        {
            //// Arrange
            var expected = 190;

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
        public void Buy_HarryPort_Different3_TotalPrice_Should_Be_270()
        {
            //// Arrange
            var expected = 270;

            var target = new ShoppingCart();

            var shoppingCart = new ShoppingCartEntity
            {
                SalePageList = new List<SalePageEntity>()
                {
                    new SalePageEntity(){Id = 1, Price = 100, Qty = 1},
                    new SalePageEntity(){Id = 2, Price = 100, Qty = 1},
                    new SalePageEntity(){Id = 3, Price = 100, Qty = 1}
                }
            };

            decimal actual = 0m;

            //// Act
            actual = target.Calculate(shoppingCart);

            //// Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Buy_HarryPort_Different4_TotalPrice_Should_Be_320()
        {
            //// Arrange
            var expected = 320;

            var target = new ShoppingCart();

            var shoppingCart = new ShoppingCartEntity
            {
                SalePageList = new List<SalePageEntity>()
                {
                    new SalePageEntity(){Id = 1, Price = 100, Qty = 1},
                    new SalePageEntity(){Id = 2, Price = 100, Qty = 1},
                    new SalePageEntity(){Id = 3, Price = 100, Qty = 1},
                    new SalePageEntity(){Id = 4, Price = 100, Qty = 1}
                }
            };

            decimal actual = 0m;

            //// Act
            actual = target.Calculate(shoppingCart);

            //// Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Buy_HarryPort_Different5_TotalPrice_Should_Be_375()
        {
            //// Arrange
            var expected = 375;

            var target = new ShoppingCart();

            var shoppingCart = new ShoppingCartEntity
            {
                SalePageList = new List<SalePageEntity>()
                {
                    new SalePageEntity(){Id = 1, Price = 100, Qty = 1},
                    new SalePageEntity(){Id = 2, Price = 100, Qty = 1},
                    new SalePageEntity(){Id = 3, Price = 100, Qty = 1},
                    new SalePageEntity(){Id = 4, Price = 100, Qty = 1},
                    new SalePageEntity(){Id = 5, Price = 100, Qty = 1}
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
