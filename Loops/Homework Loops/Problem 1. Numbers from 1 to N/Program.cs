using System;

namespace Problem_1.Numbers_from_1_to_N
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter integer number n:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                Console.Write("{0} ",i);
            }
        }
    }
}
