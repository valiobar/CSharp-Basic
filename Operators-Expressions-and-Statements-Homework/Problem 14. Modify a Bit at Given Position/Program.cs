using System;

    class Program
    {
        static void Main()
        {
        Console.Write("Enter intiger number :");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter bit value :");
        int v = int.Parse(Console.ReadLine());
        Console.Write("Enter position :");
        int p = int.Parse(Console.ReadLine());
        if (v == 0)
        {
            int element = ~(1 << p);
            int result = n & element;
            Console.WriteLine(result);
        }
        else
        {
            int element = 1 << p;
            int result = n | element;
            Console.WriteLine(result);
        }
    }
    }

