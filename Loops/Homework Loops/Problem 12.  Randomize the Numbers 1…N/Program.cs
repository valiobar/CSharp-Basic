using System;


namespace Problem_12.Randomize_the_Numbers_1_N
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number n:");
            int number = int.Parse(Console.ReadLine());
            int[] numSic = new int[number];
            int newNum = 0;
            bool unique = true;
            int count = 0;
            Random ran = new Random();
            while (count < number )
            {
                newNum = ran.Next(1, number+1);
                foreach (int item in numSic)
                {
                    if (item==newNum)
                    {
                        unique = false;
                        break;
                    }
                }
                if (unique)
                {
                    numSic[count] = newNum;
                    count++;
                }
                unique = true;
            }
            Console.Write(string.Join(" ", numSic));
            Console.WriteLine();
        }
    }
}
