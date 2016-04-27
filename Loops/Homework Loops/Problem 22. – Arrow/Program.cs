using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_22.__Arrow
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int fullarrow = 2 * (n / 2) + n;
            Console.Write(new string('.', n / 2));
            Console.Write(new string('#', n ));
            Console.WriteLine (new string('.', n / 2));
            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', n / 2),"#", new string('.', n -2));
            }
            Console.WriteLine("{0}{1}{0}", new string('#', n / 2+1), new string('.', n - 2));
            for (int i = 1; i <=n-2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', i),"#", new string('.', fullarrow-2-2*i));
            }
            Console.WriteLine("{0}{1}{0}", new string('.', fullarrow /2),"#");
        }
    }
}
