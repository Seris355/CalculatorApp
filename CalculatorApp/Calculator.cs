namespace CalculatorApp
{
    public class Calculator
    {
        public double Add(double a, double b) => a + b;

        public double Subtract(double a, double b) => a - b;

        public double Multiply(double a, double b) => a * b;

        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Деление на ноль недопустимо.");
            return a / b;
        }

        public double Power(double baseValue, double exponent) =>
            Math.Pow(baseValue, exponent);

        public double Sqrt(double value)
        {
            if (value < 0)
                throw new ArgumentException("Нельзя извлечь корень из отрицательного числа.");
            return Math.Sqrt(value);
        }
    }
}
