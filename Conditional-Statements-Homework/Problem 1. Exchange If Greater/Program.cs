using System;

namespace Problem_1.Exchange_If_Greater
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter firs number:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number:");
            int b = int.Parse(Console.ReadLine());
            int greaterNumber = a;
            if (b>greaterNumber)
            {
                Console.WriteLine("{0} {1}",a,b);
            }
            else
            {
                Console.WriteLine("{0} {1}", b, a);
            }
        }
    }
}
