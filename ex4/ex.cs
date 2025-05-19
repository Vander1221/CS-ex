using System;
using System.Collections.Generic;
using System.Linq;

public class MaxElementFinder
{
    public static int FindMaxValue(List<int> numbers)
    {
        if (numbers == null || !numbers.Any())
        {
            throw new ArgumentException("Список чисел не может быть пустым или null.");
        }

        return numbers.Max();
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Поиск максимального числа");
        Console.WriteLine("--------------------------");
        Console.WriteLine("Введите целые числа через пробел:");
        
        string input = Console.ReadLine()?.Trim();
        
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Ошибка: Вы не ввели ни одного числа.");
            return;
        }

        var numbers = new List<int>();
        var numberStrings = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

        foreach (string numberString in numberStrings)
        {
            if (int.TryParse(numberString, out int number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine($"Предупреждение: '{numberString}' не является целым числом и будет пропущено.");
            }
        }

        try
        {
            int maxValue = FindMaxValue(numbers);
            Console.WriteLine($"\nМаксимальное число: {maxValue}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"\nОшибка: {ex.Message}");
        }
    }
}