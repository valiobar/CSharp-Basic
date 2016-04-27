using System;


namespace Problem_3.Min__Max__Sum_and_Average_of_N_Numbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number n:");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];            
            int sum = 0;
            double averagde = 0;
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int min = numbers[0];
            int max = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                if (numbers[i]<min)
                {
                    min = numbers[i];
                }
                if (numbers[i]>max)
                {
                    max = numbers[i];
                }
            }
            averagde = (double)sum / n;
            Console.WriteLine("min={0}",min);
            Console.WriteLine("max={0}",max);
            Console.WriteLine("sum={0}",sum);
            Console.WriteLine("average={0:f2}",averagde);
        }
    }
}
