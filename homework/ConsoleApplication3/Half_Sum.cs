using System;


    class Half_Sum
    {
        static void Main()
        {
        int sum1 = 0;
        int sum2 = 0;
            int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
         {
            int num = int.Parse(Console.ReadLine());
             sum1 += num;

         }
        for (int i = 0; i < n; i++)
         {
            int num1 = int.Parse(Console.ReadLine());
            sum2 += num1;
         }
        if (sum1 == sum2)
        { Console.WriteLine("Yes, sum="+sum1); }
         else
        { Console.WriteLine("No, diff="+Math.Abs(sum1- sum2)) ; }
         

        }
    }
