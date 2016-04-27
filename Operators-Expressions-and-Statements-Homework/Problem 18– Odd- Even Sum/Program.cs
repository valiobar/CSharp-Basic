using System;


    class Program
    {
        static void Main()
        {
        int n = int.Parse(Console.ReadLine());
        int sumOdd = 0;
        int sumEven = 0;
        for (int i = 0; i < 2*n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                sumOdd += number;
            }
            else
                sumEven += number;
        }
        if (sumEven==sumOdd)
            Console.WriteLine("Yes, sum="+sumOdd);
        else
            Console.WriteLine("No, diff="+Math.Abs(sumOdd-sumEven));



    }
}

