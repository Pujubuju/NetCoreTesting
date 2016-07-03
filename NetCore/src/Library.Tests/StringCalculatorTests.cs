using Xunit;

namespace Library.Tests
{
    public class StringCalculatorTests
    {
        [Fact]
        public void Adds_two_numbers()
        {
            var calculator = new StringCalculator();
            Assert.Equal(5, calculator.Add("2", "3"));
        }

        [Theory]
        [InlineData("3")]
        [InlineData("5")]
        [InlineData("19")]
        public void Returns_true_for_odd_numbers(string value)
        {
            var calculator = new StringCalculator();
            Assert.True(calculator.IsOdd(value));
        }

    }
}