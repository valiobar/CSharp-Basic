using System;
using System.Collections.Generic;
using System.Linq;


namespace Problem_5.Longest_Non_Decreasing_Subsequence
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] op = input.Split(' ');
            List<int> number = op.Select(s=>int.Parse(s)).ToList<int>();
            List<int> output = new List<int>();
            output.Add(number[0]);
            for (int i = 1; i < number.Count; i++)
            {
                if (number[i]>=output[ output.Count-1])
                {
                    output.Add(number[i]);
                }
                else
                {
                    if (output.Contains(number[i]))
                    {
                        continue;
                    }
                    output.RemoveAll(s => s > number[i]);            
                    output.Add(number[i]);
                }
            }
            Console.WriteLine(string.Join(" ",output));
        }
    }
}
