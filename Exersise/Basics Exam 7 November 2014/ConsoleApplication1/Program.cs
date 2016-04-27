using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            string[,] matrix = new string[4, 8];
            string bufer = "";
            uint input = 0;
            string inputBit = "";
            string comandInput = "";
            string output = "";
            uint outputNum = 0;
            for (int i = 0; i < 4; i++)
            {
                input = uint.Parse(Console.ReadLine());
                inputBit = Convert.ToString((int)input, 2).PadLeft(32,'0');
                for (int j = 0; j < 8; j++)
                {
                    matrix[i, j] = inputBit.Substring(j * 4, 4);
                }
            }

            while (true)
            {
                comandInput = Console.ReadLine();
                if (comandInput == "End")
                {
                    break;
                }
                else
                {
                    int[] comand = comandInput.Split(' ').Select(x => int.Parse(x)).ToArray();
                    int row = comand[0];
                    int col = 7-comand[1];
                    bufer = matrix[row, col];
                    comandInput = Console.ReadLine();
                    comand = comandInput.Split(' ').Select(x => int.Parse(x)).ToArray();
                    matrix[row, col] = matrix[comand[0], 7-comand[1]];
                    matrix[comand[0], 7-comand[1]] = bufer;
                }

            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    output = output + matrix[i, j];                   
                }

                for (int p= 0; p < output.Length; p++)
                {
                    if (output[p]=='1')
                    {
                        outputNum = ((uint)1 << 31 - p) | outputNum;
                    }
                }
                
                Console.WriteLine(outputNum);
                output = "";
            }

        }
    }
}
