using System;

    class Program
    {
        static void Main()
        {
        Console.Write("Enter radius:");
        double r = double.Parse(Console.ReadLine());
        double perimeter=(2*Math.PI*r);
       double area=Math.PI*r*r;
        Console.WriteLine("perimeter:{0:f2}" , perimeter);
        Console.WriteLine("area:{0:f2}",area  );
        }
    }

