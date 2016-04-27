using System;

    class Program
    {
        static void Main()
        {
        Console.Write("Enter intiger number n:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter index p:");
        int p = int.Parse(Console.ReadLine());
        int element = n >> p;
        int bit = element & 1;
        Console.WriteLine(bit);
        }
    }

