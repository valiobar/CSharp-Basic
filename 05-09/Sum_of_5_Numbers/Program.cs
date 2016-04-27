using System;

    class Program
    {
        static void Main()
        {
        string numbers = Console.ReadLine();
        string[] numberArrey = numbers.Split(' ');
        double sum = 0;
        for (int i = 0; i < numberArrey.Length; i++)
        {

            double sumElemnt = double.Parse(numberArrey[i]);
            sum = sum + sumElemnt;
        }
        Console.WriteLine(sum);
    }
    }

