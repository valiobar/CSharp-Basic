using System;
using System.Collections.Generic;
using System.Linq;


namespace Problem_5.The_Biggest_of_3_Numbers
{
    class Program
    {
        static void Main()
        {
            int max = int.MinValue;
            int[] numbers = new int[3];
            Console.WriteLine("Enter three number each at separate line");
            for (int i = 0; i <numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            
             max = numbers.Max();
            Console.WriteLine(max);
        }
    }
}
