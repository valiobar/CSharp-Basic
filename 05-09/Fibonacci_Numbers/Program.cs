using System;

    class Program
    {
        static void Main()
        {
         int n = int.Parse(Console.ReadLine());
         int count = 0;
         int a = 0;
         int b = 1;
        if (n <= 1)
            Console.WriteLine(0); 
        else if (n == 2)
            Console.WriteLine("0 1");
        else
        {
            Console.Write("0 1 ");
            while (n - 2 > count)
            {
                int sum = a + b;
                Console.Write(sum + " ");
                a = b;
                b = sum;
                count++;

            }

        }
          
            
            
      
        }
    }
