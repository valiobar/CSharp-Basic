using System;
using System.Numerics;
namespace Problem_18.Trailing_Zeroes_in_N_
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter number n:");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
           BigInteger factoriel = 1;
            for (int i = 1; i <=n; i++)
            {
                factoriel *= i;
            }
           
            while (true)
            {
                if (factoriel%(BigInteger) Math.Pow(10,count+1)==0)
                {
                    count++;
                }
                else
                {
                    break;
                }
                
            }
            Console.WriteLine(count);
        }
    }
}
