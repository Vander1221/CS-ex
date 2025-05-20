using System; //решает квадратное уравнение вида ax² + bx + c = 0 и выводит количество действительных корней и сами корни (если они существуют)

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int c = int.Parse(input[2]);

        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            double sqrtDiscriminant = Math.Sqrt(discriminant);
            double root1 = (-b - sqrtDiscriminant) / (2 * a);
            double root2 = (-b + sqrtDiscriminant) / (2 * a);
            Console.WriteLine(2);
            Console.WriteLine($"{Math.Min(root1, root2)} {Math.Max(root1, root2)}");
        }
        else if (discriminant == 0)
        {
            double root = -b / (2.0 * a);
            Console.WriteLine(1);
            Console.WriteLine(root);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}