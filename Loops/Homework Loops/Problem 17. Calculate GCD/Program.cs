using System;


namespace Problem_17.Calculate_GCD
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter firs number:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter firs number:");
            int m = int.Parse(Console.ReadLine());
            int gCD = 0;
            while(n>0&&m>0)
            {
                if (n >= m) 
                {              
                  n = n - m;               
                }
                    else
                {
                  m = m - n;
                }              
            }
            if (n > 0)
            {
                gCD = n;
            }
            else
            {
                gCD = m;
            }
            Console.WriteLine(gCD);
        }
    }
}
