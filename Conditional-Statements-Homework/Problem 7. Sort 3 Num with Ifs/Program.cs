using System;

namespace Problem_7.Sort_3_Num_with_Ifs
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
            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine("{0} {1}  {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{0} {1}  {2}", a, c, b);
                }
            }
            else if (b > a && b > c)
            {
                if (a>c)
                {
                    Console.WriteLine("{0} {1}  {2}", b, a, c);
                }
                else
                {
                    Console.WriteLine("{0} {1}  {2}", b, c, a);
                }
            }
            else if (c>a&&c>b)
            {
                if (a > b)
                {
                    Console.WriteLine("{0} {1}  {2}", c, a, b);
                }
                else
                {
                    Console.WriteLine("{0} {1}  {2}", c, b, a);
                }

            }
        
        }
    }
}
