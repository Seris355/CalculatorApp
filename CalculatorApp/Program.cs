using CalculatorApp;

Console.WriteLine("=== Консольный калькулятор ===");
Console.WriteLine("Введите первое число:");
if (!double.TryParse(Console.ReadLine(), out double a))
{
    Console.WriteLine("Ошибка: некорректное число.");
    return;
}

Console.WriteLine("Введите операцию (+, -, *, /, ^, sqrt):");
string? op = Console.ReadLine();

double result;
var calc = new Calculator();

try
{
    if (op == "sqrt")
    {
        result = calc.Sqrt(a);
        Console.WriteLine($"sqrt({a}) = {result}");
        return;
    }

    Console.WriteLine("Введите второе число:");
    if (!double.TryParse(Console.ReadLine(), out double b))
    {
        Console.WriteLine("Ошибка: некорректное число.");
        return;
    }

    result = op switch
    {
        "+" => calc.Add(a, b),
        "-" => calc.Subtract(a, b),
        "*" => calc.Multiply(a, b),
        "/" => calc.Divide(a, b),
        "^" => calc.Power(a, b),
        _ => throw new InvalidOperationException($"Неизвестная операция: {op}")
    };

    Console.WriteLine($"{a} {op} {b} = {result}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}
