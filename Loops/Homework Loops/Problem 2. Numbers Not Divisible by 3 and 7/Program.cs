using System;

namespace Problem_2.Numbers_Not_Divisible_by_3_and_7
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter integer number n:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i%3!=0 && i%7!=0)
                {
                    Console.Write("{0} ", i);
                }
               
            }
        }
    }
}
