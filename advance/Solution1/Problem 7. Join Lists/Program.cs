using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_7.Join_Lists
{
    class Program
    {
        static void Main()
        {
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();
            List<string> firstList = firstInput.Split(' ').ToList<string>();
            List<string> secondList = secondInput.Split(' ').ToList<string>();
            firstList.AddRange(secondList);
            firstList.Sort();
            firstList= firstList.Distinct().ToList();
            Console.WriteLine(string.Join(" ",firstList));

        }
    }
}
