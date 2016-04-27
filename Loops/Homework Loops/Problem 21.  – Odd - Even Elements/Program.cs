using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_21.__Odd___Even_Elements
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] inputArr = input.Split(' ');
            int[] number = new int[inputArr.Length];
            for (int i = 0; i < inputArr.Length; i++)
            {
                number[i] = int.Parse(inputArr[i]);
            }
            int oddSum = 0;
            int oddMin = number[0];
            int oddMax = int.MinValue;
            int evenSum = 0;
            int evenMin = number[1]; ;
            int evenMax = int.MinValue;
            for (int i = 0; i < number.Length ; i = i + 2)
            {
                oddSum += number[i];
                if (number[i] > oddMax)
                {
                    oddMax = number[i];
                }
                if (number[i] < oddMin)
                {
                    oddMin = number[i];
                }
            }
            for (int i = 1; i < number.Length; i = i + 2)
            {
                evenSum += number[i];
                if (number[i] > evenMax)
                {
                    evenMax = number[i];
                }
                if (number[i] < evenMin)
                {
                    evenMin = number[i];
                }
            }
            Console.Write("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}",
              oddSum,oddMin,oddMax,evenSum,evenMin,evenMax  );
        }
    }
}
