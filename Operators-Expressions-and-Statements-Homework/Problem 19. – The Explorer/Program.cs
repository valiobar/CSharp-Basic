using System;


    class Program
    {
        static void Main()
        {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            if (i == 0 || i == n - 1)
            { string dash = new String('-', n / 2);
                Console.WriteLine("{0}{1}{0}", dash, '*', dash);
            }
            else
            {
                string dash = new String('-',Math.Abs( n /2-i));
                string dash1 = new String('-', (n - 2 - Math.Abs(2*(n /2 -i))));
                Console.WriteLine("{0}{1}{2}{1}{0}",dash,'*',dash1);
            }
           
        {

            }
        }
        }
    }

