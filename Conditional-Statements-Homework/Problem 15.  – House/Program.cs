using System;
namespace Problem_15.__House
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n / 2; i++)
            {
                string dots = new string('.', (n / 2) - i);
                string middleDots = new string('.', Math.Abs(n-(((n / 2) - i)*2 +2)));
                if (i == 0)
                {
                    Console.WriteLine("{0}{1}{0}", dots, '*');
                }
                else 
           
                Console.WriteLine("{0}{1}{2}{1}{0}",dots,'*',middleDots);
            }
            string ceiling = new string('*', n);
            Console.WriteLine(ceiling);
            for (int i = 0; i < n / 2; i++)
            {
                string dots = new string('.', n / 4);
                string middleDots = new string('.', n - (n / 2 + 2));
                string floor = new string('*', (n / 2)+1);
                if (i!=(n/2)-1)
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}",dots,'*',middleDots);
                }
                else
                    Console.WriteLine("{0}{1}{0}",dots,floor);
            }
        }
    }
}
