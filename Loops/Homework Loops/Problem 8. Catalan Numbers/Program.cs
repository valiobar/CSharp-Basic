using System;


namespace Problem_8.Catalan_Numbers
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
            double catalan = 0;
            Console.Write("Enter integer number n:");
            double n = double.Parse(Console.ReadLine());
            catalan = Fac(2 * n) / (Fac(n + 1) * Fac(n));
            Console.WriteLine(catalan);
        }
    }
}
