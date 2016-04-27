using System;
using System.Collections.Generic;
using System.Linq;


namespace Problem_9.Extract_URLs_from_Text
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter text:");
            string text = Console.ReadLine();
            List<string> textList = text.Split(' ').Where(s=>s.StartsWith("http://")||s
            .StartsWith("www.")).ToList<string>();
            Console.WriteLine(string.Join("\n",textList));
        }
    }
}
