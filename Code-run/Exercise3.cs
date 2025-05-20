using System; //решает задачу подсчета количества возможных комбинаций знаков "движение по полосам" на перекрестке

class Program
{
    static void Main()
    {
        // Ввести два числа через пробел: m (направления) и n (полосы)
        // Например: "4 2"
        string[] input = Console.ReadLine().Split();
        int m = int.Parse(input[0]); // количество возможных направлений (2 ≤ m ≤ 50)
        int n = int.Parse(input[1]); // количество полос движения (1 ≤ n ≤ 15)

        long[,] dp = new long[m + 1, n + 1];

        // Базовые случаи для 1 полосы
        for (int k = 1; k <= m; k++)
            dp[k, 1] = 1;

        for (int j = 2; j <= n; j++)
            for (int i = 1; i <= m; i++)
                for (int k = 1; k <= i; k++)
                    dp[i, j] += dp[k, j - 1];

        long result = 0;
        for (int k = 1; k <= m; k++)
            result += dp[k, n];

        Console.WriteLine(result);
    }
}