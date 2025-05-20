using System; //подсчет количества возможных маршрутов шахматного коня из левого верхнего угла доски в правый нижний угол

class Program
{
    static void Main()
    {
        //размеры доски (например: "3 2")
        string[] size = Console.ReadLine().Split();
        int rows = int.Parse(size[0]);
        int cols = int.Parse(size[1]);

        //массив для подсчета путей
        long[,] paths = new long[rows, cols];
        paths[0, 0] = 1;

        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                
                if (i == 0 && j == 0) continue;

                // возможные ходы коня
                if (i >= 2 && j >= 1)
                    paths[i, j] += paths[i - 2, j - 1];
                if (i >= 1 && j >= 2)
                    paths[i, j] += paths[i - 1, j - 2];
            }
        }

        Console.WriteLine(paths[rows - 1, cols - 1]);
    }
}