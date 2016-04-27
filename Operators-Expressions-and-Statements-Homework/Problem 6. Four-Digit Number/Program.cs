using System;

    class Program
    {
    static void Main()
    {
        Console.Write("Eneter four digit number:");
        int fourDigitNumber = int.Parse(Console.ReadLine());
        int digit = fourDigitNumber % 10;
        int ten = (fourDigitNumber / 10) % 10;
        int hundrets = (fourDigitNumber / 100) % 10;
        int tousents = fourDigitNumber / 1000;
        int sum = digit + ten + hundrets + tousents;
        Console.WriteLine(sum);
        Console.WriteLine("{0}{1}{2}{3}", digit, ten, hundrets, tousents);
        Console.WriteLine("{0}{2}{1}{3}", digit, ten, hundrets, tousents);
        Console.WriteLine("{3}{1}{2}{0}", digit, ten, hundrets, tousents);
    }
    }

