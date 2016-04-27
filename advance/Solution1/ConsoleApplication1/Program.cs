using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine();
        int[] arr = input.Split(' ').Select(int.Parse).ToArray();
        int maxVar = (1 << arr.Length);
        List<int> temp = new List<int>();
        List<int> final = new List<int>();
        for (int i = 1; i < maxVar; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                int curN = arr[j] * ((i >> j) & 1);
                if ((((i >> j) & 1) != 0) && ((temp.Count == 0) || (curN >= temp[temp.Count - 1])))
                {
                    temp.Add(curN);
                }
            }
            if (temp.Count > final.Count)
            {
                final.RemoveRange(0, final.Count);
                for (int j = 0; j < temp.Count; j++)
                {
                    final.Add(temp[j]);
                }
                temp.RemoveRange(0, temp.Count);
            }
            temp.RemoveRange(0, temp.Count);
        }
        Console.WriteLine(string.Join(" ", final));
    }
}