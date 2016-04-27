using System;


namespace Problem_8.Prime_Number_Check
{
    class Program
    {
        static void Main()
        {
            int count = 0;
            Console.WriteLine("Enter number n:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                if (n % i == 0)
                    count++;
            }
            if (count==2)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);
        }
    }
}
