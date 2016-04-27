using System;
namespace Problem_9.Matrix_of_Numbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number n:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <n; i++)
            {
                
                for (int j = i+1; j <= n+i; j++)
                {
                    Console.Write("{0} ", j);

                }
                
                Console.WriteLine();

            }
        }
    }
}
