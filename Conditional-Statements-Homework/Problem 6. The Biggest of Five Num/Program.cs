using System;

namespace Problem_6.The_Biggest_of_Five_Num
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter firs number:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter third number:");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Enter fourth number:");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Enter fifth number:");
            int e = int.Parse(Console.ReadLine());
            int max = a;
            if (b > a && b > c && b > d && b > e)
            {
                Console.WriteLine("biggest:" + b);
            }
            else if (c > a && c > b && c > d && c > e)
            {
                Console.WriteLine("biggest:" + c);
            }
            else if (d > a && d > b && d > c && d > e)
            {
                Console.WriteLine("biggest:" + d);
            }
            else if (e > a && e > b && e > c && e > d)
            {
                Console.WriteLine("biggest:" + e);

            }
            else
            {
                Console.WriteLine("biggest:" + a);
            }
        }
    }
}
