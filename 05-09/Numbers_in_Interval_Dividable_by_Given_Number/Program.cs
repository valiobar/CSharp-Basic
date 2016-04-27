using System;

    class Program
    {
        static void Main()
        {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = start; i < end; i++)
        {
            if (i % 5 == 0)
            {
                count = count + 1;
                Console.Write(i+" ");
            }
           
            
        }
        Console.WriteLine("count="+count);
    }
    }

