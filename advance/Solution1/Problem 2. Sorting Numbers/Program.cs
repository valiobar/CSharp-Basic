using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Sorting_Numbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] number = new int[n];
            for (int i = 0; i < n; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(number);
            Console.WriteLine(string.Join("\n",number));
        }
    }
}
