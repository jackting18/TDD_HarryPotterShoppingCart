using TDD_HarryPotterShoppingCart.BE;
using Xunit;

namespace TDD_HarryPotterShoppingCart.Test
{
    public class ShoppingCartTest
    {
        [Theory]
        [MemberData(nameof(ShoppingCartTestData.TestData), MemberType = typeof(ShoppingCartTestData))]
        public void ShoppingCartCalculateTest(ShoppingCartEntity shoppingCart, decimal expected)
        {
            // Arrange
            var actual = 0m;

            // Act
            var target = new ShoppingCart();
            actual = target.Calculate(shoppingCart);

            // Arrange
            Assert.Equal(expected, actual);
        }
    }
}
