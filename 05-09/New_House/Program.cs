using System;

    class Program
    {
        static void Main()
        {
        int n = int.Parse(Console.ReadLine());
        int p = n / 2;
        int starCount = 1;
        
         while(p>=0)
        {
            string keremida = new String('-', p);
            string star = new String('*', starCount);
            Console.WriteLine("{0}{1}{0}",keremida,star);
            p--;
            starCount =starCount + 2;
        }
        for (int i = 0; i < n; i++)
        {
            string floor = new String('*', n - 2);
            Console.WriteLine("|"+floor+ "|");
        }
    }
    }

