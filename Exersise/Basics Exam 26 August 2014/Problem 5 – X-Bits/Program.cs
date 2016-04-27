using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5___X_Bits
{
    class Program
    {
        static void Main()
        {
            char[,] binaryNumbers = new char[8, 32];
            char[] firstLine = new char[3];
            char[] secondLine = new char[3];
            char[] thirdLine = new char[3];
            int count = 0;
            for (int i = 0; i < 8; i++)
            {
                int input = int.Parse(Console.ReadLine());
                char[] number  = Convert.ToString(input,2).PadLeft(32,'0'). ToArray();
            
            for (int j = 0; j <number.Length; j++)
            {
                    binaryNumbers[i, j] = number[j];
            }
          }
            
            for (int i = 0; i < binaryNumbers.GetLength(0)-2; i++)
            {
                for (int j = 0; j < binaryNumbers.GetLength(1)-2; j++)
                {
                    firstLine[0]=binaryNumbers[i, j]; firstLine[1] = binaryNumbers[i, j + 1]; firstLine[2] = binaryNumbers[i,j+2];
                    secondLine[0] = binaryNumbers[i+1, j]; secondLine[1] = binaryNumbers[i+1, j + 1]; secondLine[2] = binaryNumbers[i+1, j + 2];
                    thirdLine[0] = binaryNumbers[i + 2, j]; thirdLine[1] = binaryNumbers[i + 2, j + 1]; thirdLine[2] = binaryNumbers[i + 2, j + 2];
                    if (string.Join("", firstLine)=="101"&& string.Join("", secondLine) =="010"&& string.Join("", thirdLine) == "101")
                    {
                        count++;
                    }
                    

                }
            }
            Console.WriteLine(count);
        }
    }
}
