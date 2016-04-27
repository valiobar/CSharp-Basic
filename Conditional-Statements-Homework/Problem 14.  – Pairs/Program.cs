using System;


namespace Problem_14.__Pairs
{
    class Program
    {
        static void Main()
        {
            int diff = 0;
            int sum = 0;
            int newSum = 0;
            string input = Console.ReadLine();
            string[] inputNumber = input.Split(' ');
            int[] numbers = new int[inputNumber.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(inputNumber[i]);
            }
            sum = numbers[0] + numbers[1];
            for (int i = 2; i < numbers.Length-1; i+=2)
            {
                newSum = numbers[i] + numbers[i + 1];
                   if (Math.Abs(sum-newSum)>diff)
                    {
                    diff = Math.Abs(sum - newSum);
                    }
                sum = newSum;
            }
            if (diff!=0)
            {
                Console.WriteLine("No, maxdiff="+diff);
            }
            else
                Console.WriteLine("Yes, value="+sum);
        }
    }
}
