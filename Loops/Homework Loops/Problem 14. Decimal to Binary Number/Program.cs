using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14.Decimal_to_Binary_Number
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number n:");
            long number = long.Parse(Console.ReadLine());
            List<long> newNum = new List<long>();
            while (number > 0)
            {
                newNum.Add(number  & 1);
                number = number >> 1;
            }
            
            newNum.Reverse();
            Console.WriteLine(string.Join("",newNum));
        }
    }
}
