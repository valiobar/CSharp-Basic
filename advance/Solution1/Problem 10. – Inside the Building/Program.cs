using System;

namespace Problem_10.__Inside_the_Building
{
    class Program
    {
        static void Main()
        {
            int[,] coordinates = new int[5, 2];
            int h = int.Parse(Console.ReadLine());
            for (int row = 0; row < coordinates.GetLength(0); row++)
            {
                for (int col = 0; col < coordinates.GetLength(1); col++)
                {
                    coordinates[row, col] = int.Parse(Console.ReadLine());

                }
            }
            for (int row = 0; row < coordinates.GetLength(0); row++)
            {
                if ((coordinates[row, 0] >= 0 && coordinates[row, 0] <= 3 * h
                    && coordinates[row, 1] <= h && coordinates[row, 1] >= 0) || (coordinates[row, 0] >= h && coordinates[row, 0] <= 2 * h
                    && coordinates[row, 1] <= 4 * h && coordinates[row, 1] >= 0))
                {
                    Console.WriteLine("inside");
                }
                else
                {
                    Console.WriteLine("outside");
                }
            }
        }
    }
}
