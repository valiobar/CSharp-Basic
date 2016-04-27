using System;



    class Program
    {
        static void Main()
        {
            Console.Write("Enter coordinate x:");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter coordinate y:");
            double y = double.Parse(Console.ReadLine());
            bool insiteCircle = Math.Sqrt((x-1) * (x-1) + (y-1) * (y-1)) <= 1.5;
            if (insiteCircle && y>1)
            Console.WriteLine("yes");
            else
            Console.WriteLine("no");
        }
    }
