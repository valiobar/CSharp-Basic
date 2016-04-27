using System;
using System.Collections.Generic;
using System.Linq;


namespace Problem_8.Longest_Word_in_a_Text
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter text:");
            string text = Console.ReadLine();
            List<string> textList = text.Split(' ').OrderByDescending(s => s.Length)
            .ToList<string>();
            Console.WriteLine(textList.First());
        }
    }
}
