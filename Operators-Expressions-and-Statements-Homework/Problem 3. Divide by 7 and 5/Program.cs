using System;

    class Program
    {
        static void Main()
        {
        Console.Write("Enter number to chack:");
        int number = int.Parse(Console.ReadLine());
        bool check = number %7==0 && number%5==0 ;
        Console.WriteLine(check);
        }
    }

