using System;

    class Program
    {
        static void Main()
        {
        Console.Write("Enter n:");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            double element = double.Parse( Console.ReadLine());
            sum = sum+element;
        }
        Console.WriteLine(sum);
        }
    }

