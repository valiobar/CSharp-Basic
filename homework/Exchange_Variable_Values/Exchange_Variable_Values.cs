using System;

    class Exchange_Variable_Values
    {
        static void Main()
        {
        Console.Write("Enter a:");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Before:" );
        Console.WriteLine("a ="+a);
        Console.WriteLine("b ="+b);
        int change = a;
        a=b;
        b = change;
        Console.WriteLine("After:\na =" + a + '\n' + "b =" + b);




        }
    }

