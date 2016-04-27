using System;

    class Program
    {
        static void Main()
        {
        int n = int.Parse(Console.ReadLine());
        int hull = (n - 1) / 2;
        for (int i = 0; i < n; i++)
        {
            string sailDot = new String('.', Math.Abs((n - 1) - 2 * i));
            string sailStar = new String('*',n- Math.Abs((n - 1) - 2 * i));
            string sailEmpty = new String('.', n);
            Console.WriteLine("{0}{1}{2}",sailDot,sailStar,sailEmpty);
        }
       
            for (int j = 0; j < hull; j++)
            {
                string hullStar = new String('*', 2 * n - 2 * j);
                string hullDot = new String('.',j);
                Console.WriteLine("{0}{1}{0}",hullDot,hullStar);
            }
           
        
    }
    }

