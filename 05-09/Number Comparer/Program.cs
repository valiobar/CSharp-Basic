using System;

    class Program
    {
        static void Main()
        {
        Console.Write("Enter first number:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second number:");
        double b = double.Parse(Console.ReadLine());
        if (a > b)
        { Console.WriteLine("greater:first number "); }
         if(b>a)
        { Console.WriteLine("greater:second number"); }
         else
          Console.WriteLine("The numbers are equal");
        }
    }
