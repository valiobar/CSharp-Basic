using System;

    class Program
    {
        static void Main()
        {
        int h = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        double realWork = 0.9*d;
        double worlHours = realWork * 12;
        double efficientWork = Math.Floor((worlHours * p) / 100);
        if (( efficientWork-h) >= 0)
            {
            Console.WriteLine("Yes");
            Console.WriteLine(efficientWork - h);
            }
        else
            {
            Console.WriteLine("No");
            Console.WriteLine(efficientWork - h);
            }
    }
    }

