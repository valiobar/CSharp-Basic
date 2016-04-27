using System;

    class Program
    {
        static void Main()
        {
        Console.Write("Enter number n:");
        int n = int.Parse(Console.ReadLine());
        int element = n >> 3;
        int bit = element & 1;
        Console.WriteLine(bit);
        }
    }

