using System;
using System.Linq;

public class PalindromeChecker
{
    public static bool IsPalindrome(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return false;

        // Удаляем пробелы и пунктуацию, оставляем только буквы и цифры
        string cleanText = new string(text
            .Where(c => char.IsLetterOrDigit(c))
            .ToArray())
            .ToLowerInvariant();

        if (cleanText.Length == 0)
            return false;

        // Сравниваем строку с перевернутой
        return cleanText.SequenceEqual(cleanText.Reverse());
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Введите текст для проверки:");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine("Это палиндром.");
        }
        else
        {
            Console.WriteLine("Это не палиндром.");
        }
    }
}