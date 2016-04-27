using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.Random_Numbers_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter min value:");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter max value:");
            int max = int.Parse(Console.ReadLine());
            Random ran = new Random();
            int number = 0;
            int[] num = new int[n];
            for (int i = 0; i < n; i++)
            {
                number = ran.Next(min, max);
                num[i] = number;
            }
            Console.Write(string.Join(" ",num));
            Console.WriteLine();
        }
    }
}
