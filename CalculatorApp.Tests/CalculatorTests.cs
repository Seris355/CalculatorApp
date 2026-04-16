using CalculatorApp;
using Xunit;

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calc = new Calculator();

        // ── Add ──────────────────────────────────────────────

        [Fact]
        public void Add_PositiveNumbers_ReturnsSum()
        {
            double result = _calc.Add(3, 4);
            Assert.Equal(7, result);
        }

        [Fact]
        public void Add_NegativeNumbers_ReturnsSum()
        {
            double result = _calc.Add(-3, -7);
            Assert.Equal(-10, result);
        }

        [Fact]
        public void Add_PositiveAndNegative_ReturnsSum()
        {
            double result = _calc.Add(10, -4);
            Assert.Equal(6, result);
        }

        // ── Subtract ─────────────────────────────────────────

        [Fact]
        public void Subtract_ReturnsCorrectDifference()
        {
            double result = _calc.Subtract(10, 4);
            Assert.Equal(6, result);
        }

        [Fact]
        public void Subtract_ResultIsNegative()
        {
            double result = _calc.Subtract(4, 10);
            Assert.Equal(-6, result);
        }

        // ── Multiply ─────────────────────────────────────────

        [Fact]
        public void Multiply_ReturnsCorrectProduct()
        {
            double result = _calc.Multiply(3, 4);
            Assert.Equal(12, result);
        }

        [Fact]
        public void Multiply_ByZero_ReturnsZero()
        {
            double result = _calc.Multiply(99, 0);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Multiply_TwoNegatives_ReturnsPositive()
        {
            double result = _calc.Multiply(-3, -4);
            Assert.Equal(12, result);
        }

        // ── Divide ───────────────────────────────────────────

        [Fact]
        public void Divide_ReturnsCorrectQuotient()
        {
            double result = _calc.Divide(10, 2);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(
                () => _calc.Divide(10, 0)
            );
        }

        [Fact]
        public void Divide_NegativeDividend_ReturnsNegativeQuotient()
        {
            double result = _calc.Divide(-10, 2);
            Assert.Equal(-5, result);
        }

        // ── Power ────────────────────────────────────────────

        [Fact]
        public void Power_ReturnsCorrectResult()
        {
            double result = _calc.Power(2, 10);
            Assert.Equal(1024, result);
        }

        [Fact]
        public void Power_ExponentZero_ReturnsOne()
        {
            double result = _calc.Power(99, 0);
            Assert.Equal(1, result);
        }

        // ── Sqrt ─────────────────────────────────────────────

        [Fact]
        public void Sqrt_ReturnsCorrectRoot()
        {
            double result = _calc.Sqrt(9);
            Assert.Equal(3, result);
        }

        [Fact]
        public void Sqrt_Zero_ReturnsZero()
        {
            double result = _calc.Sqrt(0);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Sqrt_NegativeNumber_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(
                () => _calc.Sqrt(-1)
            );
        }
    }
}
