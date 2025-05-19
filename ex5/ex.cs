using System;
using System.Collections.Generic;
using System.Linq;

public class DuplicateRemover
{
    public static List<int> GetUniqueNumbers(List<int> numbers)
    {
        if (numbers == null)
        {
            throw new ArgumentNullException(nameof(numbers), "Список чисел не может быть null.");
        }
        
        return numbers.Distinct().ToList();
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Удаление дубликатов чисел");
        Console.WriteLine("-------------------------");
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
            List<int> uniqueNumbers = GetUniqueNumbers(numbers);
            
            Console.WriteLine("\nУникальные числа:");
            Console.WriteLine(string.Join(" ", uniqueNumbers));
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine($"\nОшибка: {ex.Message}");
        }
    }
}