using System;

    class Program
    {
        static void Main()
        {
        Console.Write("Enter number:");
        int n = int.Parse(Console.ReadLine());
        if ((n % 2) ==0)
        {
            Console.WriteLine(false);
        }
        else
            Console.WriteLine(true);
     }
    }

