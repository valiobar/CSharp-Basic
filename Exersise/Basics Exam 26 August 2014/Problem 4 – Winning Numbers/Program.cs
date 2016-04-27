using System;
using System.Collections.Generic;
using System.Linq;


namespace Problem_4___Winning_Numbers
{
    class Program
    {
        static void Main()
        {
            int letSum = Console.ReadLine().ToLower().Select(x => (int)(x - 'a' + 1)).ToArray().Sum();
            int[] number = new int[6];
            Printcombination(0, number, letSum);
            if (count==0)
            {
                Console.WriteLine("No");
            }
        }
        static int count = 0;
        static void Printcombination(int index, int[] number, int letSum)
        {

            if (index > 5)
            {
                if ((number[0] * number[1] * number[2] == number[3] * number[4] * number[5]) && (number[0] * number[1] * number[2] == letSum))
                {
                    List<int> output = number.ToList();
                    Console.WriteLine("{0}{1}{2}", string.Join("", output.GetRange(0, 3)), '-',string.Join("" , output.GetRange(3, 3)));
                    count++;
                }
            }
            else
            {
                for (int i = 1; i <= 9; i++)
                {
                    number[index] = i;
                    Printcombination(index + 1, number, letSum);
                }
            }
        }
    }
    }