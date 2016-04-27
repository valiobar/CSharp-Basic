using System;



    class Program
    {
        static void Main()
        {
        int r = int.Parse(Console.ReadLine());
        int c= int.Parse(Console.ReadLine());
        long startV = int.Parse(Console.ReadLine());
        long startH = int.Parse(Console.ReadLine());
        for (long i = startV; i < startV+r; i++)
        {
            for (long j = startH; j <startH+ c; j++)
            {
                Console.Write("{0} ",j*i);
               
            }
            Console.WriteLine();
        }
    }
    }

