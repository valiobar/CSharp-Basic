using System;

    class Program
    {
    static void Main()
    {
        Console.Write("Enter number:");
        string number = Console.ReadLine();
        char[] check = number.ToCharArray();
        if (check.Length<3)
            Console.WriteLine(false);
        else if (check[(check.Length - 3)] == '7')
            Console.WriteLine(true);
        else
            Console.WriteLine(false);
    }

    }

