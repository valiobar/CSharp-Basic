using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5___Half_Byte_Swapper
{
    class Program
    {
        static void Main()
        {
            uint bifer = 0;
            uint bufer = 0;
            int[] comand = new int[2];
            uint[] numbers = new uint[4];
            uint firstNum = 0;
            uint secondNum = 0;
            int firstBits = 0;
            int firstIndex = 0;
            string comandInput = "";
            for (int i = 0; i < 4; i++)
            {
                numbers[i] = uint.Parse(Console.ReadLine());
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
                    comand = comandInput.Split(' ').Select(x => int.Parse(x)).ToArray();

                    firstNum = numbers[comand[0]];
                    firstBits = comand[1];
                    firstIndex = comand[0];
                    bifer = (firstNum >> (comand[1] * 4))  & 15;
                    comandInput = Console.ReadLine();
                    comand = comandInput.Split(' ').Select(x => int.Parse(x)).ToArray();
                    secondNum = numbers[comand[0]];
                    bufer = (secondNum >> (comand[1] * 4)) & 15;
                    
                    for (int i = comand[1] * 4,j=0; i < (comand[1] * 4)+4;j++, i++)
                    {
                        if (comand[0]==firstIndex)
                        {
                            if (((bifer >> j) & 1) == 1)
                            {
                                firstNum = ((uint)1 << i) | firstNum;
                            }
                            else
                                firstNum = ~((uint)1 << i) & firstNum;
                        }
                       else if (((bifer >> j) & 1) == 1)
                        {
                            secondNum = ((uint)1 << i) | secondNum;
                        }
                        else
                            secondNum = ~((uint)1 << i) & secondNum;
                    }
                    for (int i = firstBits * 4,j=0; i <(firstBits * 4)+4;j++, i++)
                    {
                        if (((bufer >> j) & 1) == 1)
                        {
                            firstNum = ((uint)1 << i) | firstNum;
                        }
                        else firstNum = ~((uint)1 << i) & firstNum;
                    }

                    if (comand[0] == firstIndex)
                    {
                        numbers[firstIndex] = firstNum;
                    }
                    else
                    {
                        numbers[comand[0]] = secondNum;
                        numbers[firstIndex] = firstNum;
                    }
                    }
             }
            Console.WriteLine(string.Join("\n",numbers));
        }
    }
}
