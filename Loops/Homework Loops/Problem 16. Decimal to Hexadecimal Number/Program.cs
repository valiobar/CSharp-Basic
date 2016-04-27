using System;
using System.Collections.Generic;

namespace Problem_16.Decimal_to_Hexadecimal_Number
{
    class Program
    {
        static void Main()
        {
             Console.WriteLine("Enter number n:");
            long n = long.Parse(Console.ReadLine());
            string[] hex = { "A","B","C","D", "E", "F" };            
            List<string> nStr = new List<string>();
             long  nNew = 0;
             while (true)
               {
                nNew = n % 16;
                if (nNew<10)
                {
                    nStr.Add(nNew.ToString());
                }
                else
                {
                    nStr.Add(hex[nNew - 10]);
                }
                    if (n/16==0)
                {
                    break;
                }
                n = n / 16;

            }
            nStr.Reverse();
            Console.WriteLine(string.Join("",nStr  ));
        }
    }
}
