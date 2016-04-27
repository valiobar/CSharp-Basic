using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sun
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{0}", new string('.', (3 * n) / 2), '*');
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < 3*n; j++)
                { 
                    
                   if (j==i||(j==(3*n-1)-i||j==((3* n)/2)))
                    {
                        Console.Write('*');
                    }
                    else Console.Write('.');
                    
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                if (i == n / 2)
                {
                    Console.WriteLine(new string('*', 3 * n));
                }
                else
                {
                    Console.WriteLine("{0}{1}{0}",new string('.',n),new string('*',n));
                }
            }
            for (int i = n-1; i >=1 ; i--)
            {
                for (int j = 0; j < 3 * n; j++)
                {

                    if (j == i || (j == (3 * n - 1) - i || j == ((3 * n) / 2)))
                    {
                        Console.Write('*');
                    }
                    else Console.Write('.');

                }
                Console.WriteLine();
            }
            Console.WriteLine("{0}{1}{0}", new string('.', (3 * n) / 2), '*');
        }
    }
}
