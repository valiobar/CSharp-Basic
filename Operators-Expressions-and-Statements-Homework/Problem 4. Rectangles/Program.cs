using System;

    class Program
    {
        static void Main()
        {
        Console.Write("Enter width:");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Enter height:");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("perimeter:"+2*(width+height));
        Console.WriteLine("area :"+width*height);
    }
    }

