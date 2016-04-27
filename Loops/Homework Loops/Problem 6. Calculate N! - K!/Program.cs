using System;

namespace Problem_6.Calculate_N____K_
{
    class Program
    {
        static double Fac(double n)
        {
            double fac = 1;
            if (n == 0)
            {
                fac = 1;
                return fac;
            }
            for (double i = 1; i <= n; i++)
            {
                fac *= i;
            }
            return fac;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter integer number n:");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer number k:");
            double k = double.Parse(Console.ReadLine());     
                        
            Console.WriteLine(Fac(n)/Fac(k));
        }
    }
}