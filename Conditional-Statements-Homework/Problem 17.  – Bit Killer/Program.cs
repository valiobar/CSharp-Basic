using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_17.__Bit_Killer
{
    class Program
    {
        static void Main()
        {
            int number = 0;
            string binaryNum = null;
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            int count = 0;
            int result = 0;
            for (int i = 0; i < n; i++)
            {
             number = int.Parse(Console.ReadLine());
             string newNum = Convert.ToString(number, 2).PadLeft(8,'0');
             binaryNum = binaryNum + newNum;
            }
            List<char> binary = binaryNum.ToList();
            for (int i = 1; i < binary.Count; i=i+step)
            {
               binary.RemoveAt(i-count);
                binary.Add('0');
                count++;

            }
        //    Console.WriteLine(string.Join("",binary));
            for (int i = 0; i < count; i++)
            {
                binary.RemoveAt(binary.Count-1);
            }
           // Console.WriteLine(string.Join("", binary));
            while (binary.Count%8!=0)
            {
                binary.Add('0');
            }
           // Console.WriteLine(string.Join("", binary));
            for (int i = 0; i < binary.Count; i=i+8)
            {
                
                for (int j = 0; j < 8; j++)
                {
                    if (binary[j + i]=='1')
                    {
                        result = result | (1 << (7 - j));
                    }
                   
                }
                Console.WriteLine(result);
                result = 0;
            }
        }
    }
}
