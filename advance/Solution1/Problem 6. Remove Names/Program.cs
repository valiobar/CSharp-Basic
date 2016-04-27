using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_6.Remove_Names
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string toCheck = Console.ReadLine();
            List<string> inputList = input.Split(' ').ToList<string>();
            List<string> checkList = toCheck.Split(' ').ToList<string>();
            for (int i = 0; i < checkList.Count; i++)
            {
                if (inputList.Contains(checkList[i]))
                {
                    inputList.RemoveAll(s => s == checkList[i]);
                }
            }
            Console.WriteLine(string.Join(" ", inputList));
        }
    }
}
