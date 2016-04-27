using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13.Binary_to_Decimal_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter binary number n:");
            char[] numChr = Console.ReadLine().ToArray();
            long newNum = 0;
            long bit = 0;
            long pow = numChr.Length - 1;
            string[] numStr = new string[numChr.Length];            
            for (int i = 0; i < numChr.Length; i++)
            {
                numStr[i] = numChr[i].ToString();
            }
            for (int i = 0; i < numChr.Length; i++)
            {
                bit = int.Parse(numStr[i]);
                newNum =newNum+ bit * (long)Math.Pow(2, pow);
                pow--;
            }
            Console.WriteLine(newNum);
        }
    }
}
