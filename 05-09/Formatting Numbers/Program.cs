using System;

class Program
{
    static void Main()
    {
        Console.Write("enter a:");
        int a = int.Parse(Console.ReadLine());
        string bimary = Convert.ToString(a, 2);
        string binaryPad = "00" + bimary;
        Console.Write("enter b:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("enter c:");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("|{0,-10:X} |{1,10}|{2,10:f2}|{3,-10:f3}|", a, binaryPad, b, c);
    }
}

