using System;
using System.Numerics;

public class FactorialCalculator
{
    public static BigInteger CalculateFactorial(int n)
    {
        if (n < 0)
            throw new ArgumentOutOfRangeException(nameof(n), "Факториал определен только для неотрицательных чисел.");
        
        BigInteger result = 1;
        
        // Начинаем цикл с 2, так как умножение на 1 не меняет результат
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        
        return result;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Вычисление факториала");
        
        Console.Write("Введите целое неотрицательное число: ");
        string input = Console.ReadLine();
        
        if (!int.TryParse(input, out int number))
        {
            Console.WriteLine("Ошибка: введено не целое число.");
            return;
        }

        try
        {
            BigInteger factorial = CalculateFactorial(number);
            Console.WriteLine($"\nРезультат: {number}! = {factorial}");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"\nОшибка: {ex.Message}");
        }
        catch (Exception)
        {
            Console.WriteLine("\nПроизошла непредвиденная ошибка при вычислениях.");
        }
    }
}