using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4___Weird_Combinations
{
    class Program
    {
        static void Main()
        {
            char[] input = Console.ReadLine().ToArray();
            int n = int.Parse(Console.ReadLine());
            char[] combination = new char[input.Length];
            PrintCombination(input, 0, n, combination);
            if (have)
            {
                Console.WriteLine("No");
            }
        }
        static int count = 0;
        static bool have = true;
        static void PrintCombination(char[] input,int index,int n,char[] combination)
        {

            if (index > input.Length - 1)
            {

                if (count==n)
                {
                    Console.WriteLine(string.Join("", combination));
                    have = false;
                }
                count++;
            }
            else
            {
                for (int i =0; i < input.Length; i++)
                {
                    combination[index] = input[i];
                    PrintCombination(input, index + 1, n, combination);
                    
                }
            }
            
        }
       
    }
}
