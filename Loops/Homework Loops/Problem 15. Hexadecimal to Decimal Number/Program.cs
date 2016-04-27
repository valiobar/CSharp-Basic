using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_15.Hexadecimal_to_Decimal_Number
{
    class Program
    {
        static void Main()
        {
       
        Console.WriteLine("Enter number n:");
        string hexNUmber = Console.ReadLine();
        char[] numchr = hexNUmber.ToArray();
        string[] numstr = new string[numchr.Length];
        long pow = numstr.Length-1;
        List<string> hex =new string[] { "A", "B", "C", "D", "E", "F" }.ToList();        
        long nNew = 0;
            long number = 0;
            for (int i = 0; i < numstr.Length; i++)
            {
                numstr[i] = numchr[i].ToString();
            }
            for (int i = 0; i < numstr.Length; i++)
            {
                if (long.TryParse(numstr[i], out nNew))
                {
                    nNew= nNew * (long)Math.Pow(16, pow);
                    number = number + nNew;
                }
                else
                {
                    nNew = (10 + hex.IndexOf(numstr[i]))* (long)Math.Pow(16, pow);
                    number = number + nNew;
                }
                pow--;
            }

            Console.WriteLine(number);

        }
    }
}
