using System;
using System.Linq;

public class SumCalculator
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введите числа через пробел:");
        string input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Ошибка: Вы не ввели ни одного числа.");
            return;
        }

        string[] numberStrings = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var numbers = new int[numberStrings.Length];
        int validNumbersCount = 0;
        bool hasErrors = false;

        for (int i =  0; i < numberStrings.Length; i++)
        {
            if (int.TryParse(numberStrings[i], out int number))
            {
                numbers[validNumbersCount++] = number;
            }
            else
            {
                hasErrors = true;
            }
        }

        if (hasErrors)
        {
            Console.WriteLine("Предупреждение: Некоторые значения не были числами и были проигнорированы.");
        }

        if (validNumbersCount > 0)
        {
            int sum = numbers.Take(validNumbersCount).Sum();
            Console.WriteLine($"Сумма введенных чисел: {sum}");
        }
        else
        {
            Console.WriteLine("Нет допустимых чисел для суммирования.");
        }
    }
}