using System;


namespace Problem_7.Calculate_N___K_x_N_K___
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
        static void Main()
        {
            double combinationNum = 0;
            Console.Write("Enter integer number n:");
            double n = double.Parse(Console.ReadLine());
            Console.Write("Enter integer number k:");
            double k = double.Parse(Console.ReadLine());
            combinationNum = Fac(n) /( Fac(k) * Fac(n - k));
            Console.WriteLine(combinationNum);

        }
    }
}
