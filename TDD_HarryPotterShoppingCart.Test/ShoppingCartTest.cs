using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TDD_HarryPotterShoppingCart.Test
{
    public class ShoppingCartTest
    {
        [Fact]
        public void Buy_1_HarryPort_TotalPrice_Should_Be_100()
        {
            //// Arrange
            var expected = 100;

            var target = new ShoppingCart();
            decimal actual = 0m;

            //// Act
            actual = target.Calculate();

            //// Assert
            Assert.Equal(expected, actual);
        }
    }
}
