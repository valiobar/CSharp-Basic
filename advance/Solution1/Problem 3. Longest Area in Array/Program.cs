using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Longest_Area_in_Array
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] str = new string[n];
            int longCount = 1;
            int curCount = 1;
            int starindex = 0;
            for (int i = 0; i < n; i++)
            {
               str[i] = Console.ReadLine();
            }
           
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == str[i - 1])
                {
                    curCount++;
                }
                else curCount = 1;
                if (curCount>longCount)
                {
                    longCount = curCount;
                    starindex = i - longCount + 1;
                }
               
            }
            for (int i = starindex; i <=starindex+ longCount-1; i++)
            {
                Console.WriteLine(str[i]);
            }
        }
    }
}
