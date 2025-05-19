using System;

public class Calculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Простой калькулятор");
        Console.WriteLine("--------------------");

        while (true)
        {
            double num1, num2;
            char op;

            // Ввод первого числа с проверкой
            num1 = GetValidNumber("Введите первое число:");

            // Ввод оператора с проверкой
            op = GetValidOperator("Введите оператор (+, -, *, /):");

            // Ввод второго числа с проверкой
            num2 = GetValidNumber("Введите второе число:");

            try
            {
                double result = Calculate(num1, num2, op);
                Console.WriteLine($"\nРезультат: {num1} {op} {num2} = {result}\n");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: деление на ноль!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            if (!ShouldContinue())
                break;
        }
    }

    private static double GetValidNumber(string prompt)
    {
        while (true)
        {
            Console.WriteLine(prompt);
            if (double.TryParse(Console.ReadLine(), out double number))
                return number;
            
            Console.WriteLine("Ошибка: введите корректное число!");
        }
    }

    private static char GetValidOperator(string prompt)
    {
        while (true)
        {
            Console.WriteLine(prompt);
            char op = Console.ReadLine().Trim()[0];
            if ("+-*/".Contains(op))
                return op;
            
            Console.WriteLine("Ошибка: введите один из операторов: +, -, *, /");
        }
    }

    private static double Calculate(double num1, double num2, char op)
    {
        return op switch
        {
            '+' => num1 + num2,
            '-' => num1 - num2,
            '*' => num1 * num2,
            '/' => num2 == 0 ? throw new DivideByZeroException() : num1 / num2,
            _ => throw new InvalidOperationException("Неизвестный оператор")
        };
    }

    private static bool ShouldContinue()
    {
        Console.WriteLine("Продолжить? (да/нет)");
        string answer = Console.ReadLine()?.Trim().ToLower();
        return answer == "да" || answer == "д";
    }
}