using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Calculate_sum
{
    class Program
    {
        static int Fac(int n)
        {
            int fac = 1;
            if (n==0)
            {
                fac = 1;
                return fac;
            }
            for (int i = 1; i <= n; i++)
            {
                fac *= i;
            }
            return fac;
        }
        static void Main(string[] args)
        {
            double sum = 1;
            Console.WriteLine("Enter integer number n:");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer number x:");
            double x = double.Parse(Console.ReadLine());
            double newSum = 0;
            for (int i = 1; i <=n; i++)
            {
                newSum = Fac(i) / Math.Pow(x, i);
                sum += newSum;
            }
            Console.WriteLine("{0:f5}",sum);
        }
    }
}
